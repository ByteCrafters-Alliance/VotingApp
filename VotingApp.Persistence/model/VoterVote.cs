using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingApp.Persistence.model
{
    public class VoterVote
    {
        public Guid VoterId { get; set; }   
        public Guid VotingId { get; set; }
        public Guid VotingOption { get; set; }
        public DateTime VotedDate { get; set; }
        public bool ValidVote { get; set; }

    }
}