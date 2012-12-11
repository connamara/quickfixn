namespace QuickFix
{
    public class ResendRange
    {
        public int BeginSeqNo { get; set; }
        public int EndSeqNo { get; set; }

        public ResendRange()
            : this(0, 0)
        { }

        public ResendRange(int begin, int end)
        {
            BeginSeqNo = begin;
            EndSeqNo = end;
        }

        public override string ToString()
        {
            return BeginSeqNo + ":" + EndSeqNo;
        }
    }
}
