using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using VotingApp.API.Model;

namespace VotingApp
{
    public sealed class VoteHub: Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceivedMessage", $"{Context.ConnectionId} has joined!!");
        }

        public async Task BroadcastVote(int totalvotes)
        {
            await Clients.All.SendAsync("ReceiveVoteUpdate", totalvotes);
        }
    }
}