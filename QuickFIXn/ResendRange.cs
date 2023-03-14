namespace QuickFix
{
    public class ResendRange
    {
        public ulong BeginSeqNo { get; set; }
        public ulong EndSeqNo { get; set; }
        public ulong ChunkEndSeqNo { get; set; }

        public ResendRange()
        {
            BeginSeqNo = 0;
            EndSeqNo = 0;
            ChunkEndSeqNo = 0;
        }

        public override string ToString()
        {
            return BeginSeqNo + ":" + EndSeqNo;
        }
    }
}
