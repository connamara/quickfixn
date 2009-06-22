require 'rexml/document'
require 'field'
require 'field_gen'

class Generator  
  def self.generate
    generator = Generator.new
    generator.generate_fields
  end
  
  def initialize
    @fix44 = loadXML('../spec/fix/FIX44.xml')
    @fields = Field.process_all( @fix44.elements["fix/fields"] )
  end
    
  def loadXML( filename )
   return( REXML::Document.new( File.new( filename ) ))
  end
  
  def generate_fields
    FieldGen.generate_tags( @fields, '../QuickFIX.NET/Fields' )
  end
end


Generator.generate