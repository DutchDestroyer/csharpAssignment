using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zivver.Candidate.Assignment.Models
{
    public class Message
    {
        public string AccountId { get; }

        public List<string> Recipients { get; }

        public string ConversationId { get; }

        public int MessageId { get; }

        public string SenderFirstName { get; }

        public string SenderLastName { get; }

        public bool IsSent { get; }

        public bool IsZivverMessage { get; }

        public bool IsDraft { get; }

        public string Subject { get; }

        public string Body { get; }

    }
}
