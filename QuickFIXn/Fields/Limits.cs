
namespace QuickFix.Fields
{
    public static class Limits
    {
        public const int FIX40_LAST_FIELD = Tags.PrevClosePx;
        public const int FIX41_LAST_FIELD = Tags.PegDifference;
        public const int FIX42_LAST_FIELD = Tags.EncodedListStatusText;
        public const int FIX43_LAST_FIELD = Tags.SideComplianceID;
        public const int FIX44_LAST_FIELD = Tags.LegInterestAccrualDate;
        public const int FIX50_LAST_FIELD = Tags.ExchangeSpecialInstructions;

        public const int NORMAL_MIN = 1;
        public const int NORMAL_MAX = 4999;
        public const int USER_MIN = 5000;
        public const int USER_MAX = 9999;
        public const int INTERNAL_MIN = 10000;
    }
}
