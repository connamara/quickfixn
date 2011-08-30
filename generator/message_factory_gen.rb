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

namespace QuickFix
{
    namespace #{fixver}
    {
        public class MessageFactory : IMessageFactory
        {
#{gen_method_create(messages,fixver)}

#{gen_method_group(messages,fixver)}
        }
    }
}
HERE
  end


  def self.gen_method_create(messages,fixvar)
return <<HERE
            public Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
#{gen_method_create_cases(messages,fixvar)}
                }

                return new QuickFix.Message();
            }
HERE
  end


  def self.gen_method_group(messages,fixvar)
return <<HERE
            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                throw new System.Exception();
            }
HERE
  end


  def self.gen_method_create_cases(messages,fixvar)
    indent = " "*4*5;
    messages.map {|m|
        indent + "case QuickFix.#{fixvar}.#{m[:name]}.MsgType: return new QuickFix.#{fixvar}.#{m[:name]}();"
    }.join("\n")
  end
end
