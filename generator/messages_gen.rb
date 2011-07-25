

class MessageGen
  def self.generate messages, dir, fixver
    messages.select {|m| m[:name] == 'TradeCaptureReport'}.each do |msg| 
      msgstr = gen_msg(msg, fixver)
      msg_path = File.join(dir, fixver, msg[:name] + '.cs')
      puts msg_path
      File.open(msg_path, 'w') {|f| f.puts(msgstr) }
    end
  end

  def self.gen_msg msg, fixver 
<<HERE
using QuickFix.Fields;
namespace QuickFix
{
    namespace #{fixver} 
    {
        public class #{msg[:name]} : Message
        {
            #region Properties
#{gen_msg_fields(msg[:fields])}
            #endregion
        }
    }
}
HERE
  end

  def self.gen_msg_fields fields
    fields.map { |fld| (' '*12) + msg_field(fld) }.join("\n")
  end

  def self.msg_field fld
    "public QuickFix.Fields.#{fld[:name]} #{fld[:name]} { get; set; }"
  end
end
