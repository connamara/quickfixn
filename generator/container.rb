require 'entries'

class Container
  attr_reader :elements, :name
  def initialize( container, field_map, component_map )
    @name = container.attributes['name']
    @elements = []
    container.elements.each('*') do |el|
      req = el.attributes['required']=='Y'
      entry = nil
      case el.name 
        when 'field'     then entry = FieldEntry
        when 'group'     then entry = GroupEntry
        when 'component' then entry = ComponentEntry
        else raise "invalid element: name='#{el.name}'\n#{el.inspect}"
      end
      @elements << entry.new( el, req, field_map, component_map )
    end
  end  
  
  def get_name( el )
    el.attributes['name']
  end
end

class Group < Container
end

class Component < Container
  def self.ProcessAll( comp_elements, field_map )
    component_map = {}
    comp_elements.elements.each do |component| 
      component_map[component.attributes['name']] = Component.new( component, component_map, field_map )
    end
    return component_map
  end
end

