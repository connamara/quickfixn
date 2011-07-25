$LOAD_PATH << File.dirname(__FILE__)

require 'fix_dictionary'
require 'fields_gen'
require 'messages_gen'

class Generator  
  def self.generate
    generator = Generator.new
    generator.generate_fields
    generator.generate_messages
  end
  
  def initialize
    #@fix40 = FIXDictionary.load '../spec/fix/FIX40.xml'
    #@fix41 = FIXDictionary.load '../spec/fix/FIX41.xml'
    #@fix42 = FIXDictionary.load '../spec/fix/FIX42.xml'
    #@fix43 = FIXDictionary.load '../spec/fix/FIX43.xml'
    @fix44 = FIXDictionary.load '../spec/fix/FIX44.xml'
    @fix50 = FIXDictionary.load '../spec/fix/FIX50.xml'
    @src_path = File.join File.dirname(__FILE__), '..', 'QuickFIX.NET'
  end
    
  def generate_fields
    fields_path = File.join(@src_path, 'Fields', 'Fields.cs')
    tags_path = File.join(@src_path, 'Fields', 'FieldTags.cs')
    FieldGen.generate(@fix50.fields.values,  fields_path, tags_path)
  end

  def generate_messages
    msgs_path = File.join(@src_path, 'Message')
    MessageGen.generate(@fix44.messages,  msgs_path, 'FIX44')
  end
end


Generator.generate
