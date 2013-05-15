namespace QuickFix
{
    public class ResendRange
    {
        public int BeginSeqNo { get; set; }
        public int EndSeqNo { get; set; }
        public int ChunkEndSeqNo { get; set; }

        public ResendRange()
        {
            BeginSeqNo = 0;
            EndSeqNo = 0;
            ChunkEndSeqNo = -1;
        }

        [System.Obsolete("Not used, so probably get rid of this in v2")]
        public ResendRange(int begin, int end)
        {
            BeginSeqNo = 0;
            EndSeqNo = 0;
            ChunkEndSeqNo = -1;
        }

        public override string ToString()
        {
            return BeginSeqNo + ":" + EndSeqNo;
        }
    }
}
