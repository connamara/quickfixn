require 'container'

class Message < Container
  attr_reader :msgcat, :msgtype
  
  def initialize( xmlmsg, field_map, component_map )
    @msgcat = xmlmsg.attributes['msgcat']
    @msgtype = xmlmsg.attributes['msgtype']
    super( xmlmsg, field_map, component_map )
  end
  
  def self.process_all( xmlmsgs, field_map, component_map )
    messages = {}
    xmlmsgs.elements.each do |msg|
      m = Message.new( msg, field_map, component_map )
      messages[m.name] = m
    end
    return messages
  end
end
