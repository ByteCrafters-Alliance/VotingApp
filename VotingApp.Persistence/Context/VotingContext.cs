using Microsoft.EntityFrameworkCore;
using VotingApp.Persistence.model;

namespace VotingApp.Persistence.Context
{
    public class VotingContext : DbContext
    {
        public DbSet<VoteOption> VoteOptions {get;set;}
        public DbSet<Voter> Voters { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<VoterVote> VotersVotes { get; set; }
    }
}