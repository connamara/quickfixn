$LOAD_PATH << File.dirname(__FILE__)

require 'fix_dictionary'
require 'fields_gen'
require 'messages_gen'
require 'proj_gen'

class Generator  
  def self.generate
    generator = Generator.new
    generator.generate_csproj
    generator.generate_fields
    generator.generate_messages
  end
  
  def initialize
    @fix40 = FIXDictionary.load '../spec/fix/FIX40.xml'
    @fix41 = FIXDictionary.load '../spec/fix/FIX41.xml'
    @fix42 = FIXDictionary.load '../spec/fix/FIX42.xml'
    @fix43 = FIXDictionary.load '../spec/fix/FIX43.xml'
    @fix44 = FIXDictionary.load '../spec/fix/FIX44.xml'
    @fix50 = FIXDictionary.load '../spec/fix/FIX50.xml'
    @src_path = File.join File.dirname(__FILE__), '..', 'QuickFIX.NET'
  end
    
  def generate_fields
    fields_path = File.join(@src_path, 'Fields', 'Fields.cs')
    tags_path = File.join(@src_path, 'Fields', 'FieldTags.cs')
    FieldGen.generate(agg_fields, fields_path, tags_path)
  end

  def agg_fields
    field_names = (@fix40.fields.keys + @fix41.fields.keys +
        @fix42.fields.keys + @fix43.fields.keys +
        @fix44.fields.keys + @fix50.fields.keys).uniq
    field_names.map {|fn| get_field_def(fn) }
  end

  def get_field_def fld_name
    # we give priority to latest fix version
    fld   = @fix50.fields[fld_name]
    fld ||= @fix44.fields[fld_name]
    fld ||= @fix43.fields[fld_name]
    fld ||= @fix42.fields[fld_name]
    fld ||= @fix41.fields[fld_name]
    fld ||= @fix40.fields[fld_name]
    raise "couldn't find field! #{fld}" if fld.nil?
    fld
  end

  def generate_messages
    msgs_path = File.join(@src_path, 'Message')
    MessageGen.generate(@fix40.messages,  msgs_path, 'FIX40')
    MessageGen.generate(@fix41.messages,  msgs_path, 'FIX41')
    MessageGen.generate(@fix42.messages,  msgs_path, 'FIX42')
    MessageGen.generate(@fix43.messages,  msgs_path, 'FIX43')
    MessageGen.generate(@fix44.messages,  msgs_path, 'FIX44')
    MessageGen.generate(@fix50.messages,  msgs_path, 'FIX50')
  end

  def generate_csproj
    csproj_path = File.join(@src_path, 'FixMessages.csproj')
    CSProjGen.generate(
      csproj_path,
      [
        {:version=>'FIX40', :messages=>@fix40.messages},
        {:version=>'FIX41', :messages=>@fix41.messages},
        {:version=>'FIX42', :messages=>@fix42.messages},
        {:version=>'FIX43', :messages=>@fix43.messages},
        {:version=>'FIX44', :messages=>@fix44.messages},
        {:version=>'FIX50', :messages=>@fix50.messages}
      ]
    )
  end
end


Generator.generate
