class MessageTypesGen
  def self.generate(messages, dir, fixver)
    destdir = File.join(dir,fixver)
    Dir.mkdir(destdir) unless File.exists?(destdir)
    file_path = File.join(destdir,"MsgTypes.cs")
    puts 'generate ' + file_path

    content = gen_message_types(messages,fixver)
    File.open(file_path, 'w') {|f| f.puts(content)}
  end


  def self.gen_message_types(messages,fixver)
return <<HERE
// This is a generated file.  Don't edit it directly!

using System.IO;
using System.Reflection;
using System.Xml;

namespace QuickFix
{
    namespace #{fixver}
    {
#{gen_msgtypes_enum(messages,fixver)}        
    }
}
HERE
  end

  def self.gen_msgtypes_enum(messages,fixver)
return <<HERE
        internal static class MsgTypes
        {
            public static int GetMsgType(string msgType)
            {
                int result = 0;
                for (int i = 0; i < msgType.Length; i++)
                {
                    result += (msgType[i]<<(8*i));
                }
                return result;
            }
          
#{gen_msgtypes_enum_values(messages)}
        }
HERE
  end

  def self.gen_msgtypes_enum_values(messages)
    indent = " "*4*3
    messages.map {|m| indent + gen_msgtype_enum_value(m)  }.join("\n")
  end

  def self.gen_msgtype_enum_value(m) 
      length = m[:msgtype].length
      
      result = "public const int #{m[:name]} = '#{m[:msgtype][0]}'"

      i = 1
      while i < length do
          ch = m[:msgtype][i]
          result = result + " + ('#{ch}' << #{i*8})"
          i = i + 1
      end
      
      result = result + ';'
      
      result
  end
end
