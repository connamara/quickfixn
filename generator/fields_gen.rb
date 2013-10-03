

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
      when 'INT', 'NUMINGROUP', 'SEQNUM', 'LENGTH'
        {:cs_class => 'IntField', :base_type=>'int'}
      when 'AMT', 'PERCENTAGE', 'PRICE', 'QTY', 'PRICEOFFSET', 'FLOAT'
        {:cs_class => 'DecimalField', :base_type=>'Decimal'}
      when 'UTCTIMESTAMP', 'TZTIMESTAMP', 'TIME'
        {:cs_class => 'DateTimeField', :base_type=>'DateTime'}
      when 'UTCDATEONLY','UTCDATE','DATE'
        {:cs_class => 'DateOnlyField', :base_type=>'DateTime'}
      when 'UTCTIMEONLY'
        {:cs_class => 'TimeOnlyField', :base_type=>'DateTime'}
      when 'BOOLEAN' 
        {:cs_class => 'BooleanField', :base_type=>'Boolean'}
      when 'STRING', 'MULTIPLEVALUESTRING',  'MULTIPLECHARVALUE', 
           'DATA', 'EXCHANGE', 'LOCALMKTDATE', 'MONTHYEAR', 'DAYOFMONTH', 
           'COUNTRY', 'TZTIMEONLY', 'MULTIPLESTRINGVALUE', 'XMLDATA',
	   'LANGUAGE', 'CURRENCY'
        {:cs_class => 'StringField', :base_type=>'string'}
      when nil 
        raise "field type is nil! #{field.inspect}"
      else 
        raise "field type not supported! #{field[:fldtype]}"
    end
  end

  def self.fields_str fields
<<HERE
// This is a generated file.  Don't edit it directly!

using System;

namespace QuickFix.Fields
{
#{
    fields.map{|f|
      if ["DateTimeField","TimeOnlyField"].include? f[:cs_class]
       date_field_str f
      else  
       field_str f
     end
    }.join("\n")
  }
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
#{fields.map {|f| tag_str(f)}.join("\n")}
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
#{fix_values(field)}
    }

HERE
  end

  def self.date_field_str field
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
        public #{field[:name]}(#{field[:base_type]} val, bool showMilliseconds)
	    :base(Tags.#{field[:name]}, val, showMilliseconds) {}
#{fix_values(field)}
    }

HERE
  end


  def self.fix_values fld
		return '' if fld[:values].nil? or fld[:values].empty?
		vals = ["\n", "        // Field Enumerations"]
		vals += fld[:values].map do |val|
			enum = val[:enum].clone
			desc = val[:desc].clone

			# make desc ok for C# vars
		  desc = 'VAL_' + desc if desc =~ /^(\d+)(.*)/
			desc.gsub!('.','_')

		  case fld[:base_type]
			when 'int'
		    "        public const int #{desc} = #{enum};"
			when 'string'
		    "        public const string #{desc} = \"#{enum}\";"
			when 'char'
		    "        public const char #{desc} = '#{enum}';"
			when 'Boolean'
				tf = (enum=='Y' ? "true;" : "false;")
		    "        public const Boolean #{desc} = #{tf}"
			else
				raise "bad field val #{fld[:name]} #{fld[:base_type]} - #{val.inspect}"
			end
		end
		vals.join("\n")
  end

end

  


