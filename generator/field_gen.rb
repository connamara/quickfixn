
module FieldGen
  def self.generate_tags( field_map, output_dir=nil )
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
end
