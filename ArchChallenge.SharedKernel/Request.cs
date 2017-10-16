using System;

namespace ArchChallenge.SharedKernel
{
    public class Request
    {
        public string TransactionID { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}