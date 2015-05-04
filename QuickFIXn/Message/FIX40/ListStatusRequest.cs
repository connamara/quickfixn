using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class ListStatusRequest : Message
    {
        public const string MsgType = "M";

        public ListStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public ListStatusRequest(QuickFix.Fields.ListID aListID)
               : this()
        {
            this.ListID = aListID;
        }

        public QuickFix.Fields.ListID ListID
        {
            get
            {
                var val = new QuickFix.Fields.ListID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ListID val) { this.ListID = val; }

        public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ListID val) { return IsSetListID(); }

        public bool IsSetListID() { return IsSetField(Tags.ListID); }

        public QuickFix.Fields.WaveNo WaveNo
        {
            get
            {
                var val = new QuickFix.Fields.WaveNo();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.WaveNo val) { this.WaveNo = val; }

        public QuickFix.Fields.WaveNo Get(QuickFix.Fields.WaveNo val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.WaveNo val) { return IsSetWaveNo(); }

        public bool IsSetWaveNo() { return IsSetField(Tags.WaveNo); }

        public QuickFix.Fields.Text Text
        {
            get
            {
                var val = new QuickFix.Fields.Text();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Text val) { this.Text = val; }

        public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Text val) { return IsSetText(); }

        public bool IsSetText() { return IsSetField(Tags.Text); }


    }
}


