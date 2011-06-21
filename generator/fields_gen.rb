

class FieldGen
  def self.generate fields, fields_path, tags_path
    fields.map! {|fld| fld.merge! type_info(fld) }
    File.open(fields_path, 'w') {|f| f.puts fields_str(fields) }
    File.open(tags_path, 'w') {|f| f.puts tags_str(fields) }
  end

  def self.type_info( field )
    case field[:fldtype]
      when 'CHAR' 
        {:cs_class => 'CharField', :base_type=>'char'}
      when 'INT', 'NUMINGROUP', 'SEQNUM'
        {:cs_class => 'IntField', :base_type=>'int'}
      when 'AMT', 'PERCENTAGE', 'CURRENCY', 'PRICE', 'QTY', 'PRICEOFFSET', 'LENGTH', 'FLOAT'
        {:cs_class => 'DecimalField', :base_type=>'Decimal'}
      when 'UTCTIMESTAMP', 'UTCDATEONLY', 'UTCTIMEONLY', 'TZTIMESTAMP'
        {:cs_class => 'DateTimeField', :base_type=>'DateTime'}
      when 'BOOLEAN' 
        {:cs_class => 'BooleanField', :base_type=>'Boolean'}
      when 'STRING', 'MULTIPLEVALUESTRING',  'MULTIPLECHARVALUE', 
           'DATA', 'EXCHANGE', 'LOCALMKTDATE', 'MONTHYEAR', 'DAYOFMONTH', 
           'COUNTRY', 'TZTIMEONLY', 'MULTIPLESTRINGVALUE'
        {:cs_class => 'StringField', :base_type=>'string'}
      when nil 
        raise "field type is nil! #{field.inspect}"
      else 
        raise "field type not supported! #{field[:fldtype]}"
    end
  end

  def self.fields_str fields
<<HERE
using System;

namespace QuickFix.Fields
{
#{fields.map {|f| field_str f }.join("\n\r")}
}
HERE
  end

  def self.tags_str fields
<<HERE
using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// FIX Field Tag Values
    /// </summary>/
    public static class Tags
    {
#{fields.map {|f| tag_str(f)}.join("\n\r")}
    }
}
HERE

    
  end

  def self.tag_str fld
    "        public const int #{fld[:name]} = #{fld[:tag]};"
  end

  def self.field_str field
<<HERE
    /// <summary>
    /// #{field[:name]} Field
    /// </summary>/
    public sealed class #{field[:name]} : #{field[:cs_class]}
    {
        public #{field[:name]}()
            :base(Tags.#{field[:name]}) {}
        public #{field[:name]}(#{field[:base_type]} val)
            :base(Tags.#{field[:name]}, val) {}
    }

HERE
  end


end

  


