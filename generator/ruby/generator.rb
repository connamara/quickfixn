require 'nokogiri'
require 'mustache'
require 'fileutils'

GENERATOR_ROOT = File.expand_path("../", __FILE__)

Mustache.template_path = GENERATOR_ROOT

class MessageBase
  attr_accessor :version, :service_pack
  TEMPLATE = "#{GENERATOR_ROOT}/templates/message_base.mustache"

  def initialize(version, service_pack = nil)
    @version = version
    @service_pack = service_pack || version
  end

  def to_s
    Mustache.render(File.read(TEMPLATE), { version: version, service_pack: service_pack })
  end
end

class MessageFactory
  attr_accessor :data_dictionary, :messages, :version, :groups, :messages_with_groups
  TEMPLATE = "#{GENERATOR_ROOT}/templates/message_factory.mustache"

  def initialize(dd)
    @data_dictionary = dd
    @version = dd.fix_version
    @messages = dd.messages
    @messages_with_groups = dd.messages.select { |m| !m.groups.empty? }
  end

  def flatten_groups(msg, collection = [])
    msg.groups.each do |group|
      collection << group
      flatten_groups(group, collection)
    end

    collection
  end

  def to_s
    Mustache.render(File.read(TEMPLATE), {
      version: version,
      messages: messages,
      messages_with_groups: messages_with_groups.map { |msg| msg.groups = flatten_groups(msg); msg }
    })
  end
end

class Message
  attr_accessor :name, :message_type, :constructor_arguments, :fields, :groups, :xml_node
  TEMPLATE = "#{GENERATOR_ROOT}/templates/message.mustache"

  def initialize(xml_node)
    @xml_node = xml_node
    @name = xml_node.attr('name')
    @message_type = xml_node.attributes["msgtype"].value
    @constructor_arguments = []
    @fields = []
    @groups = []
  end

  def parent; nil end;

  def constructor_list
    list = @constructor_arguments.each_with_index.map do |arg, i|
      add_comma = (i < @constructor_arguments.length - 1)
      add_comma ? "QuickFix.Fields.#{arg} a#{arg}," : "QuickFix.Fields.#{arg} a#{arg}"
    end
    list
  end

  def components
    @components ||= @xml_node.children.select { |c| c.name === "component"}
  end

  def find_group(name)
    @groups.find { |g| g.name.downcase === name.downcase }
  end

  def to_s
    Mustache.render(File.read(TEMPLATE), { name: name })
  end
end

class Field
  attr_accessor :name, :required, :message
  TEMPLATE = "#{GENERATOR_ROOT}/templates/field.mustache"

  def initialize(xml_node, message)
    @message = message
    @name = xml_node.attr('name')
    @required = xml_node["required"] == "Y"
  end

  alias_method :required?, :required

  def to_s
    Mustache.render(File.read(TEMPLATE), { name: name })
  end
end

class Group
  attr_accessor :fields, :name, :required, :groups, :message, :parent
  TEMPLATE = "#{GENERATOR_ROOT}/templates/group.mustache"

  def initialize(xml_node, message, parent = nil)
    @message = message
    @name = xml_node.attr('name')
    @required = xml_node["required"] == "Y"
    @parent = parent
    @fields = []
    @groups = []
  end

  def parents
    str = ''
    current = self
    until current.parent.nil?
      if current.parent.is_a?(Group)
        str.prepend(".#{current.parent.name}Group")
      else
        str.prepend("#{current.parent.name}")
      end
      current = current.parent
    end
    str
  end

  def first_field
    @fields[0]
  end

  def to_s
    Mustache.render(File.read(TEMPLATE), {
      name: name,
      fields: @fields,
      groups: @groups,
      first_field: first_field
    })
  end
end

class DataDictionay
  attr_reader :xdoc, :messages, :fix_version

  def initialize(xdoc)
    @xdoc = xdoc
    @fix_version = extract_fix_version
    @messages = []
    parse
  end

  def extract_fix_version
    attrs = @xdoc.xpath('fix')[0].attributes
    if attrs["servicepack"] && attrs["servicepack"].value.to_i > 0
      "FIX#{attrs["major"].value}#{attrs["minor"].value}SP#{attrs["servicepack"].value}"
    else
      "FIX#{attrs["major"].value}#{attrs["minor"].value}"
    end
  end

  def save(root_directory)
    @messages.each do |message|
      f_path = "#{root_directory}/#{@fix_version}/#{message.name}.cs"
      FileUtils::mkdir_p(File.dirname(f_path))
      File.open(f_path, "w") do |f|
        message_file_content = Mustache.render(File.read(Message::TEMPLATE), {
          version: @fix_version,
          msgName: message.name,
          msgType: message.message_type,
          msgConstructorArguments: message.constructor_arguments,
          msgConstructorList: message.constructor_list,
          hasConstructorArguments: !message.constructor_arguments.empty?,
          msgFields: message.fields,
          msgGroups: message.groups
        })
        f.write(message_file_content)
      end
    end
  end

  def parse
    @xdoc.xpath('fix/messages/message').to_a.each do |message|
      msg = Message.new(message)

      fields = []
      message.elements.to_a.each do |node|
        # all groups will be also included in message#fields property
        parse_node(node, msg, fields)
      end

      build_constructor_args(fields, msg)

      msg.fields = fields
      msg.groups = fields.select { |f| f.is_a?(Group) }
      @messages << msg
    end
  end

  def parse_node(node, message, collection = [], parent = nil)
    case node.name
    when 'field'
      collection << Field.new(node, message)
    when 'group'
      children = node.elements.remove
      grp = Group.new(node, message, parent || message)
      collection << grp
      children.each { |n| parse_node(n, message, grp.fields, grp) }
      grp.groups = grp.fields.select { |f| f.is_a?(Group) }
    when 'component'
      # if you don't dup it, you may lose child fields if they're a group
      comp = find_component(node.attr('name')).dup
      comp.elements.to_a.each { |n| parse_node(n, message, collection, parent) }
    end
  end

  def build_constructor_args(fields, msg)
    # Build constructor args by searching for all required fields,
    # ignoring conditionally required component fields
    fields.each do |field|
      next unless field.is_a?(Field) && field.required?

      if !msg.components.empty?
        component = msg.components.find do |c|
          exp_comp = find_component(c.attr('name'))
          exp_comp.children.find { |c_node| c_node.attr('name') === field.name }
        end

        if !component
          msg.constructor_arguments << field.name
        elsif component && component.attr('required') == "Y"
          msg.constructor_arguments << field.name
        else
          # no op for non-required component's required fields
        end
      else
        msg.constructor_arguments << field.name
      end
    end
  end

  def find_component(name)
    @xdoc.xpath("fix/components/component[@name='#{name}']")[0]
  end

  def find_message(name)
    @messages.find { |m| m.name.downcase == name.downcase }
  end
end
