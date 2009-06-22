
module FieldGen
  def self.type_helper( field )
    case(field.ftype)
      when 'CHAR' then return 'CharField'
      when 'STRING' then return 'StringField'
      when 'INT' then return 'IntField'
      when 'AMT' then return 'DecimalField'
      when 'PERCENTAGE' then return 'DecimalField'
      when 'BOOLEAN' then return 'BooleanField'
      when 'CURRENCY' then return 'DecimalField'
      when 'LOCALMKTDATE' then return 'DateTimeField'
      when 'PRICE' then return 'DecimalField'
      when 'QTY' then return 'DecimalField'
      when 'SEQNUM' then return 'IntField'
      when 'PRICEOFFSET' then return 'DecimalField'
      when 'LENGTH' then return 'DecimalField'
      when 'FLOAT' then return 'DecimalField'
      when 'UTCTIMESTAMP' then return 'DateTimeField'
      when 'MONTHYEAR' then return 'DateTimeField'
      when 'MULTIPLEVALUESTRING' then return 'StringField'
      when 'COUNTRY' then return 'StringField'
      when 'DATA' then return 'StringField'
      when 'EXCHANGE' then return 'StringField'
      when 'NUMINGROUP' then return 'IntField'
      when 'UTCDATEONLY' then return 'DateTimeField'
      when 'UTCTIMEONLY' then return 'DateTimeField'
      else raise "field type not supported! #{field.ftype}"
    end
  end

  def self.generate( fields, output_dir )
    self.generate_tags( fields, output_dir )
    self.generate_fields( fields, output_dir )
  end

  def self.generate_tags( field_map, output_dir )
    fields = field_map.values.sort{ |f1, f2| f1.name <=> f2.name }
    f = File.new( "#{output_dir}/FieldTags.cs", 'w' )
    f.puts 'using System;'
    f.puts ''
    f.puts 'namespace QuickFIX.NET.Fields'
    f.puts '{'
    f.puts '    /// <summary>'
    f.puts '    /// FIX Field Tag Values'
    f.puts '    /// </summary>/'
    f.puts '    public static class Tags'
    f.puts '    {'
    fields.each do |field|
      f.puts "        public static int #{field.name} = #{field.num};"
    end
    f.puts '    }'
    f.puts '}'
  end

  def self.generate_fields( field_map, output_dir )
    fields = field_map.values.sort{ |f1, f2| f1.name <=> f2.name }
    fields.each { |f| type_helper( f ) }
    return # we aren't ready for this yet
    f = File.new( "#{output_dir}/FieldTags.cs", 'w' )
    f.puts 'using System;'
    f.puts ''
    f.puts 'namespace QuickFIX.NET.Fields'
    f.puts '{'
    fields.each do |field|
      f.puts "    public sealed class #{field.name} : #{type_helper(field)};"
      f.puts '    /// <summary>'
      f.puts '    /// FIX Field Tag Values'
      f.puts '    /// </summary>/'
    end
  end
end
