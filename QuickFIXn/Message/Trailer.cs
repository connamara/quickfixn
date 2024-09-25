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

        /// <summary>
        /// Creates a FIX (ish) string representation of this FieldMap (does not change the object state)
        /// </summary>
        /// <returns></returns>
        public override string CalculateString() {
            return base.CalculateString(new StringBuilder(), TRAILER_FIELD_ORDER);
        }

        /// <summary>
        /// Creates a FIX (ish) string representation of this FieldMap (does not change the object state)
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="preFields"></param>
        /// <returns></returns>
        public override string CalculateString(StringBuilder sb, int[] preFields) {
            return base.CalculateString(sb, TRAILER_FIELD_ORDER);
        }
    }
}
