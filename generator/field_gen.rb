
module FieldGen
  def self.base_type_helper( field )
    case(field.ftype)
      when 'CHAR' then return 'char'
      when 'STRING' then return 'string'
      when 'INT' then return 'int'
      when 'AMT' then return 'Decimal'
      when 'PERCENTAGE' then return 'Decimal'
      when 'BOOLEAN' then return 'Boolean'
      when 'CURRENCY' then return 'Decimal'
      when 'LOCALMKTDATE' then return 'DateTime'
      when 'PRICE' then return 'Decimal'
      when 'QTY' then return 'Decimal'
      when 'SEQNUM' then return 'int'
      when 'PRICEOFFSET' then return 'Decimal'
      when 'LENGTH' then return 'Decimal'
      when 'FLOAT' then return 'Decimal'
      when 'UTCTIMESTAMP' then return 'DateTime'
      when 'MONTHYEAR' then return 'DateTime'
      when 'MULTIPLEVALUESTRING' then return 'string'
      when 'COUNTRY' then return 'string'
      when 'DATA' then return 'string'
      when 'EXCHANGE' then return 'string'
      when 'NUMINGROUP' then return 'int'
      when 'UTCDATEONLY' then return 'DateTime'
      when 'UTCTIMEONLY' then return 'DateTime'
      else raise "field type not supported! #{field.ftype}"
    end
  end

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
      f.puts "        public const int #{field.name} = #{field.num};"
    end
    f.puts '    }'
    f.puts '}'
    f.close
  end

  def self.generate_fields( field_map, output_dir )
    f = File.new( "#{output_dir}/Fields.cs", 'w' )
    fields = field_map.values.sort{ |f1, f2| f1.name <=> f2.name }
    f.puts 'using System;'
    f.puts ''
    f.puts 'namespace QuickFIX.NET.Fields'
    f.puts '{'
    fields.each do |field|
      f.puts '    /// <summary>'
      f.puts "    /// #{field.name} Field"
      f.puts '    /// </summary>/'
      f.puts "    public sealed class #{field.name} : #{type_helper(field)}"
      f.puts '    {'
      f.puts "        public #{field.name}()"
      f.puts "            :base(Tags.#{field.name}) {}"
      f.puts "        public #{field.name}(#{base_type_helper(field)} val)"
      f.puts "            :base(Tags.#{field.name}, val) {}"
      f.puts "    }"
      f.puts ""
      f.puts ""
    end
    f.puts '}'
    f.close
  end
end
