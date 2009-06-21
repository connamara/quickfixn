require 'container'

class Message < Container
  attr_reader :msgcat, :msgtype
  
  def initialize( xmlmsg, field_map, component_map )
    @msgcat = xmlmsg.attributes['msgcat']
    @msgtype = xmlmsg.attributes['msgtype']
    super( xmlmsg, field_map, component_map )
  end
  
  def self.process_all( msgs, field_map, component_map )
    messages = Array.new
    msgs.elements.each { |msg| messages << Message.new( msg, field_map, component_map ) }
    return messages.sort {|m1,m2| m1.name <=> m2.name }
  end
end
