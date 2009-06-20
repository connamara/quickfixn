require 'value'

class Field
  attr_reader :name, :ftype, :num, :values
  
  def initialize( field )
    @name = field.attributes['name']
    @num = field.attributes['number']
    @ftype = field.attributes['type']
    @values = []
    field.elements.each('value') do |val| 
      @values << Value.new( val.attributes['enum'], val.attributes['description'] )
    end
  end
  
  def self.process_all( field_elements )
    fields = {}
    field_elements.elements.each do |field| 
      f = Field.new( field )
      fields[f.name] = f
    end
    return fields
  end
end
