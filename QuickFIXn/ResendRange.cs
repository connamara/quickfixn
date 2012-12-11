namespace QuickFix
{
    public class ResendRange
    {
        public int BeginSeqNo { get; set; }
        public int EndSeqNo { get; set; }
        public int ChunkEndSeqNo { get; set; }

        public ResendRange()
            : this(0, 0)
        { }

        public ResendRange(int begin, int end, int chunkEnd=-1)
        {
            BeginSeqNo = begin;
            EndSeqNo = end;
            ChunkEndSeqNo = chunkEnd == -1 ? EndSeqNo : chunkEnd;
        }

        public override string ToString()
        {
            return BeginSeqNo + ":" + EndSeqNo;
        }
    }
}
