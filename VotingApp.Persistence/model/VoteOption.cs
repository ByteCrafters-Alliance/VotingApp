using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingApp.Persistence.model
{
    public class VoteOption
    {
        public Guid VoteOptionId { get; set; }
        public string VoteOptionTitle { get; set; }
        public string Description { get; set; }
    }
}