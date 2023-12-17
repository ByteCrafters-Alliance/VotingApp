using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingApp.Persistence.model
{
    public class Channel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string ChannelName { get; set; }
        public string Author { get; set; }
        public DateTime CreatedData { get; set; }  
        public DateTime LastUpdated { get; set; }
        public VotingStatus StatusId { get; set; }
    }

    public enum VotingStatus
    {
        Draft,
        Open,
        Closed,
        Cancelled
    }
}