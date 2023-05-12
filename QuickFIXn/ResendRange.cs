namespace QuickFix
{
    public class ResendRange
    {
        public const ulong NOT_SET = System.UInt64.MaxValue;

        public ulong BeginSeqNo { get; set; }
        public ulong EndSeqNo { get; set; }
        public ulong ChunkEndSeqNo { get; set; }

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
