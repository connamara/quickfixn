namespace QuickFix
{
    public class ResendRange
    {
        public const SeqNumType NOT_SET = SeqNumType.MaxValue;

        public SeqNumType BeginSeqNo { get; set; }
        public SeqNumType EndSeqNo { get; set; }
        public SeqNumType ChunkEndSeqNo { get; set; }

        public ResendRange()
        {
            BeginSeqNo = 0;
            EndSeqNo = 0;
            ChunkEndSeqNo = ResendRange.NOT_SET;
        }

        public override string ToString()
        {
            return BeginSeqNo + ":" + EndSeqNo;
        }
    }
}
