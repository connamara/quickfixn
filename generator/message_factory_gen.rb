class MessageFactoryGen
  def self.generate(messages, dir, fixver)
    destdir = File.join(dir,fixver)
    Dir.mkdir(destdir) unless File.exists?(destdir)
    file_path = File.join(destdir,"MessageFactory.cs")
    puts 'generate ' + file_path

    content = gen_factory(messages,fixver)
    File.open(file_path, 'w') {|f| f.puts(content)}
  end


  def self.gen_factory(messages,fixver)
return <<HERE
// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix
{
    namespace #{fixver}
    {
        public class MessageFactory : IMessageFactory
        {
#{get_method_supported_beginstrings(messages,fixver)}
			
#{gen_method_create(messages,fixver)}

#{gen_method_group(messages,fixver)}
        }
    }
}
HERE
  end

  def self.get_method_supported_beginstrings(messages,fixver)
return <<HERE
            public ICollection<string> GetSupportedBeginStrings()
            {
				return new [] { BeginString.#{fixver} };
            }
HERE
  end

  def self.gen_method_create(messages,fixver)
return <<HERE
            public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
            {
                return Create(beginString, msgType);
            }


            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
#{gen_method_create_cases(messages,fixver)}
                }

                return new QuickFix.Message();
            }
HERE
  end


  def self.gen_method_group(messages,fixver)
return <<HERE
            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
#{gen_method_group_ifs(messages,fixver)}
                return null;
            }
HERE
  end


  def self.gen_method_create_cases(messages,fixver)
    indent = " "*4*5
    messages.map {|m|
        indent + "case QuickFix.#{fixver}.#{m[:name]}.MsgType: return new QuickFix.#{fixver}.#{m[:name]}();"
    }.join("\n")
  end


  def self.gen_method_group_ifs(messages,fixver)
    indent = " "*4*4
    lines = Array.new
    messages.each {|m|
      if(m[:groups].length > 0)
        lines << indent + "if (QuickFix.#{fixver}.#{m[:name]}.MsgType.Equals(msgType))"
        lines << indent + "{"
        lines << indent + "    switch (correspondingFieldID)"
        lines << indent + "    {"

        m[:groups].each {|g|
          gen_method_group_groups(m,fixver,g,"",lines,indent)
        }

        lines << indent + "    }"
        lines << indent + "}"
        lines << ""
      end
    }
    lines.join("\n")
  end
  
  def self.gen_method_group_groups(message,fixver,thisgroup,path,lines,indent)
    lines << indent + "        case QuickFix.Fields.Tags.#{thisgroup[:name]}: return new QuickFix.#{fixver}.#{message[:name]}#{path}.#{thisgroup[:name]}Group();"
  
    thisgroup[:groups].each {|g| 
      gen_method_group_groups(message,fixver,g,"#{path}.#{thisgroup[:name]}Group",lines,indent);
    }
  end  
end
