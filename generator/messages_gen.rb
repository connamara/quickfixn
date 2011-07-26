

class MessageGen
  def self.generate messages, dir, fixver
    messages.select {|m| m[:name] == 'TradeCaptureReport'}.each do |msg| 
      msgstr = gen_msg(msg, fixver)
      msg_path = File.join(dir, fixver, msg[:name] + '.cs')
      puts msg_path
      File.open(msg_path, 'w') {|f| f.puts(msgstr) }
    end
  end

  def self.lower str
    str = str.clone
    str[0] = str[0].downcase
    str
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
#{gen_msg_groups(msg[:groups])}
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
    req = required_fields(msg)
    req_args = req.map {|r| ' '*20 + "QuickFix.Fields.#{r[:name]} a#{r[:name]}" }
    req_setters = req.map {|r| ' '*16 + "this.#{lower(r[:name])} = a#{r[:name]};" }
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

  def self.gen_msg_groups groups
    groups.map { |grp| msg_grp(grp) }.join("\n")
  end


  def self.required_fields msg
    msg[:fields].select {|f| f[:required] == true and f[:group] == false }
  end

  def self.msg_field fld
<<HERE
            public QuickFix.Fields.#{fld[:name]} #{lower(fld[:name])}
            { 
                get 
                {
                    QuickFix.Fields.#{fld[:name]} val = new QuickFix.Fields.#{fld[:name]}();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }

            public void set(QuickFix.Fields.#{fld[:name]} val) 
            { 
                this.#{lower(fld[:name])} = val;
            }

            public QuickFix.Fields.#{fld[:name]} get(QuickFix.Fields.#{fld[:name]} val) 
            { 
                getField(val);
                return val;
            }

            public bool isSet(QuickFix.Fields.#{fld[:name]} val) 
            { 
                return isSet#{fld[:name]}();
            }

            public bool isSet#{fld[:name]}() 
            { 
                return isSetField(Tags.#{fld[:name]});
            }
HERE
  end

  def self.msg_grp grp
<<HERE
            public class #{grp[:name]} : Group
            {
                public #{grp[:name]}() 
                  :base( 
                    Tags.#{grp[:fields][0][:name]},
                    Tags.#{grp[:fields][1][:name]},
                    new int[] {#{grp_field_order grp[:fields] }})
                {
                }
            }
HERE
  end
  def self.grp_field_order fields
    field_order = fields.map {|f| "Tags.#{f[:name]}"}
    field_order << "0"  ## um, because qf and qfj do it
    field_order.join(", ")
  end
end
