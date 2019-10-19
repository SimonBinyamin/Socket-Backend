using Microsoft.AspNetCore.SignalR;
using socketController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace socketController.PHub
{
    public class PlayerHub : Hub
    {


        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message, message);
        }

        /// <summary>
        /// Template on how to create a private chat
        /// </summary>
        public void Send(Player message)
        {
            //var t1 = new
            //{
            //    fName = "",
            //    sName = "",
            //    responseConnId = ""
            //};

            //List<string> connIds = new List<string>();
            //connIds.Add(Context.ConnectionId);
            //connIds.Add(t1.responseConnId);

            //await Clients.Clients(connIds).SendAsync("ReceiveMessage", t1, message);

            Clients.All.SendAsync("ReceiveMessage", message);

        }


    }
}
