using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MobileRepairMT.Hubs;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MobileRepairMT.Controllers
{ 
    [ApiController]
    [Route("api/chathub")]

    public class ChatHubController : Controller
    {
        private readonly IHubContext<ChatHub> _chatHub;
        public ChatHubController([NotNull]IHubContext <ChatHub> chatHub)
        {
            _chatHub = chatHub;
        }
        [HttpPost]
        public async Task<IActionResult> Create(MessagePost messagePost )
        {

            await _chatHub.Clients.All.SendAsync("sendToReact", "The Message" + messagePost.Message + "'has been received'");
            return Ok();
        }
    }
    public class MessagePost
    {
        public virtual string Message { get; set; }
    }
}
