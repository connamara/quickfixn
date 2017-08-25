

class MessageGen
  def self.generate messages, dir, fixver
    destdir = File.join(dir, fixver)
    Dir.mkdir(destdir) unless File.exists? destdir

    basemsgstr = gen_basemsg(fixver,destdir)
    basemsg_path = File.join(destdir, "Message.cs")
    puts 'generate ' + basemsg_path
    File.open(basemsg_path, 'w') {|f| f.puts(basemsgstr) }

    messages.each do |msg| 
      msgstr = gen_msg(msg, fixver)
      msg_path = File.join(destdir, msg[:name] + '.cs')
      puts 'generate ' + msg_path
      File.open(msg_path, 'w') {|f| f.puts(msgstr) }
    end
  end

  def self.lower rawstr
    str = rawstr.clone
    str.slice(0,1).downcase + str.slice(1,rawstr.length)
  end

  def self.gen_basemsg fixver, destdir
    beginstring = fixver.match(/^FIX50/) ? "FIXT11" : fixver
<<HERE
// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace #{fixver}
    {
        public abstract class Message : QuickFix.Message
        {
            public Message()
                : base()
            {
                this.Header.SetField(new QuickFix.Fields.BeginString(QuickFix.FixValues.BeginString.#{beginstring}));
            }
        }
    }
}
HERE
  end

  def self.gen_msg msg, fixver 
<<HERE
// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace #{fixver} 
    {
        public class #{msg[:name]} : Message
        {
#{msgtype(msg)}
#{ctor(msg)}
#{ctor_req(msg)}
#{gen_msg_fields(msg[:fields], 12)}
#{gen_msg_groups(msg[:groups], 12)}
        }
    }
}
HERE
  end

  def self.msgtype msg
<<HERE
            public const string MsgType = "#{msg[:msgtype]}";
HERE
  end

  def self.ctor msg
<<HERE
            public #{msg[:name]}() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("#{msg[:msgtype]}"));
            }
HERE
  end

  def self.ctor_req msg
    req = required_fields(msg)
    return '' if req.empty?
    req_args = req.map {|r| ' '*20 + "QuickFix.Fields.#{r[:name]} a#{r[:name]}" }
    req_setters = req.map {|r| ' '*16 + "this.#{(r[:name])} = a#{r[:name]};" }
<<HERE
            public #{msg[:name]}(
#{req_args.join(",\n")}
                ) : this()
            {
#{req_setters.join("\n")}
            }
HERE
  end

  def self.gen_msg_fields fields, prepend_spaces
    fields.map { |fld| msg_field(fld,prepend_spaces) }.join("\n")
  end

  def self.gen_msg_groups groups, prepend_spaces
    groups.map { |grp| msg_grp(grp, prepend_spaces) }.join("\n")
  end


  def self.required_fields msg
    msg[:fields].select {|f| f[:required] == true and f[:group] == false }
  end

  def self.msg_field fld, prepend_spaces
    str = []
    str << "public QuickFix.Fields.#{fld[:name]} #{fld[:name]}"
    str << "{ "
    str << "    get "
    str << "    {"
    str << "        QuickFix.Fields.#{fld[:name]} val = new QuickFix.Fields.#{fld[:name]}();"
    str << "        GetField(val);"
    str << "        return val;"
    str << "    }"
    str << "    set { SetField(value); }"
    str << "}"
    str << ""
    str << "public void Set(QuickFix.Fields.#{fld[:name]} val) "
    str << "{ "
    str << "    this.#{(fld[:name])} = val;"
    str << "}"
    str << ""
    str << "public QuickFix.Fields.#{fld[:name]} Get(QuickFix.Fields.#{fld[:name]} val) "
    str << "{ "
    str << "    GetField(val);"
    str << "    return val;"
    str << "}"
    str << ""
    str << "public bool IsSet(QuickFix.Fields.#{fld[:name]} val) "
    str << "{ "
    str << "    return IsSet#{fld[:name]}();"
    str << "}"
    str << ""
    str << "public bool IsSet#{fld[:name]}() "
    str << "{ "
    str << "    return IsSetField(Tags.#{fld[:name]});"
    str << "}"
    str.map! {|s| ' '*prepend_spaces + s}
    str.join("\n")
  end

  def self.msg_grp grp, prepend_spaces
    str = []
    str << "public class #{grp[:name]}Group : Group"
    str << "{"
    str << "    public static int[] fieldOrder = {#{grp_field_order grp[:fields] }};"
    str << ""
    str << "    public #{grp[:name]}Group() "
    str << "      :base( Tags.#{grp[:group_field][:name]}, Tags.#{grp[:fields][0][:name]}, fieldOrder)"
    str << "    {"
    str << "    }"
    str << ""
    str << "    public override Group Clone()"
    str << "    {"
    str << "        var clone = new #{grp[:name]}Group();"
    str << "        clone.CopyStateFrom(this);"
    str << "        return clone;"
    str << "    }"
    str << ""
    str << gen_msg_fields(grp[:fields], prepend_spaces+4)
    str << gen_msg_groups(grp[:groups], prepend_spaces+4)
    str << "}"
    str.map {|s| ' '*prepend_spaces + s}.join("\n")
  end

  def self.grp_field_order fields
    field_order = fields.map {|f| "Tags.#{f[:name]}"}
    field_order << "0"  ## um, because qf and qfj do it
    field_order.join(", ")
  end
end
