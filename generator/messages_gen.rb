

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
#{ctor(msg)}
#{ctor_req(msg)}
            #region Properties
#{gen_msg_fields(msg[:fields])}
            #endregion
        }
    }
}
HERE
  end

  def self.ctor msg
<<HERE
            public #{msg[:name]}() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("#{msg[:msgtype]}"));
            }
HERE
  end

  def self.ctor_req msg
    req = required(msg)
    req_args = req.map {|r| ' '*20 + "#{r[:name]} a#{r[:name]}" }
    req_setters = req.map {|r| ' '*16 + "this.#{r[:name]} = a#{r[:name]};" }
<<HERE
            public #{msg[:name]}(
#{req_args.join(",\n")}
                ) : this()
            {
#{req_setters.join("\n")}
            }
HERE
  end

  def self.gen_msg_fields fields
    fields.map { |fld| msg_field(fld) }.join("\n")
  end

  def self.required msg
    msg[:fields].select {|f| f[:required] == true } + 
    msg[:groups].select {|g| g[:required] == true }
  end

  def self.msg_field fld
<<HERE
            public void set(QuickFix.Fields.#{fld[:name]} val) 
            { 
                this.#{fld[:name]} = val;
            }
            public QuickFix.Fields.#{fld[:name]} get(QuickFix.Fields.#{fld[:name]} val) 
            { 
                getField(val);
                return val;
            }
            public QuickFix.Fields.#{fld[:name]} #{fld[:name]}
            { 
                get 
                {
                    #{fld[:name]} val = new #{fld[:name]}();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
HERE
  end
end
