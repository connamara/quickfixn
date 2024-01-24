#nullable enable
using System;
using System.Text;
using QuickFix.Fields;

namespace QuickFix {
    public class Trailer : FieldMap {
        public int[] TRAILER_FIELD_ORDER = { Tags.SignatureLength, Tags.Signature, Tags.CheckSum };

        public Trailer()
            : base() {
        }

        public Trailer(Trailer src)
            : base(src) {
        }

        public override string CalculateString() {
            return base.CalculateString(new StringBuilder(), TRAILER_FIELD_ORDER);
        }

        public override string CalculateString(StringBuilder sb, int[] preFields) {
            return base.CalculateString(sb, TRAILER_FIELD_ORDER);
        }
    }
}
