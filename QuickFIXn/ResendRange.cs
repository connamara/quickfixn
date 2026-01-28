using System;

namespace QuickFix
{
    public class ResendRange
    {
        public const SeqNumType NOT_SET = SeqNumType.MaxValue;

        public SeqNumType BeginSeqNo { get; private set; }

        /// <summary>
        /// Final sequence number needed, regardless of configured MaxMessagesInResendRequest.
        /// If it's zero (aka infinity) then TriggerSeqNo has the real value.
        /// </summary>
        public SeqNumType EndSeqNo { get; private set; }

        /// <summary>
        /// If set, this is the EndSeqNo of the active ResendRequest,
        /// because of MaxMessagesInResendRequest.
        /// </summary>
        public SeqNumType ChunkEndSeqNo { get; private set; }

        public bool IsResendStarted { get; private set; }

        /// <summary>
        /// The original too-high seq num
        /// (so we can track the end of the resend if EndSeqNo=0 aka infinity)
        /// </summary>
        public SeqNumType TriggerSeqNo { get; private set; }

        public ResendRange()
        {
            Reset();
        }

        public void Reset()
        {
            BeginSeqNo = 0;
            EndSeqNo = 0;
            ChunkEndSeqNo = ResendRange.NOT_SET;
            TriggerSeqNo = 0;
            IsResendStarted = false;
        }

        public void Set(
            SeqNumType beginSeqNo, SeqNumType endSeqNo, SeqNumType triggerSeqNo,
            Message resendRequest, SeqNumType endChunkSeqNo = NOT_SET)
        {
            BeginSeqNo = beginSeqNo;
            EndSeqNo = endSeqNo;
            ChunkEndSeqNo = endChunkSeqNo;
            TriggerSeqNo = triggerSeqNo;
            IsResendStarted = false;
        }

        public void MarkAsStarted()
        {
            IsResendStarted = true;
        }

        public void UpdateChunk(SeqNumType chunkBegin, SeqNumType chunkEnd)
        {
            BeginSeqNo = chunkBegin;
            ChunkEndSeqNo = chunkEnd;
            IsResendStarted = false;
        }

        /// <summary>
        /// If EndSeqNo is 0, then need to derive the end from TriggerSeqNo
        /// </summary>
        public SeqNumType ActualEndSeqNo => EndSeqNo > 0 ? EndSeqNo : TriggerSeqNo - 1;

        public override string ToString()
        {
            string chunkEnd = ChunkEndSeqNo == NOT_SET ? "-" : ChunkEndSeqNo.ToString();
            return
                $"{BeginSeqNo}:{EndSeqNo} (ChunkEndSeqNo={chunkEnd} IsResendStarted={IsResendStarted} TriggeredSeqNo={TriggerSeqNo})";
        }
    }
}

