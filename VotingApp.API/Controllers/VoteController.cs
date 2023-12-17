using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using VotingApp.API.Model;

namespace VotingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoteController : ControllerBase
    {
        private readonly IHubContext<VoteHub> _hubContext;

        public VoteController(IHubContext<VoteHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> CastVote([FromQuery] string candidate)
        {
            // Perform your voting logic here

            // For demonstration purposes, let's assume there's a method to get the total votes
            int totalVotes = GetTotalVotes();
            
            // Broadcast the updated total votes to all clients
            await _hubContext.Clients.All.SendAsync("ReceiveVoteUpdate", totalVotes + 1);

            return Ok();
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                // Your logic to get the total votes goes here
                int totalVotes = GetTotalVotes();

                return Ok(totalVotes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private int GetTotalVotes()
        {
            // Your actual logic to get the total votes goes here
            // For simplicity, let's assume there's a variable storing the total votes
            return 42;
        }
    }
}