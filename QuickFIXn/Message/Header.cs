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

        /// <summary>
        /// Creates a FIX (ish) string representation of this FieldMap (does not change the object state)
        /// </summary>
        /// <returns></returns>
        public override string CalculateString() {
            return base.CalculateString(new StringBuilder(), HEADER_FIELD_ORDER);
        }

        /// <summary>
        /// Creates a FIX (ish) string representation of this FieldMap (does not change the object state)
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="preFields"></param>
        /// <returns></returns>
        public override string CalculateString(StringBuilder sb, int[] preFields) {
            return base.CalculateString(sb, HEADER_FIELD_ORDER);
        }
    }
}
