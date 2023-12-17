
namespace VotingApp.API.Model;
public class Vote
{
    public int Id { get; set; }
    public required string UserName { get; set; }
    public required string VotedOption { get; set; }
}
