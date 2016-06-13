using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppServer.Hubs
{
    [HubName("Chat")]
    public class ChatHub : Hub
    {
        [HubMethodName("Send")]
        public void Send(string message)
        {
            Clients.All.Receive(message);
        }
    }
}
