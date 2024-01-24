#nullable enable
using System;
using System.Text;
using QuickFix.Fields;

namespace QuickFix {
    public class Header : FieldMap {
        public int[] HEADER_FIELD_ORDER = { Tags.BeginString, Tags.BodyLength, Tags.MsgType };

        public Header()
            : base() {
        }

        public Header(Header src)
            : base(src) {
        }

        public override string CalculateString() {
            return base.CalculateString(new StringBuilder(), HEADER_FIELD_ORDER);
        }

        public override string CalculateString(StringBuilder sb, int[] preFields) {
            return base.CalculateString(sb, HEADER_FIELD_ORDER);
        }
    }
}
