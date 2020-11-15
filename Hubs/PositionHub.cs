using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignnalRFirst.Hubs
{
    public class PositionHub : Hub
    {
        public async Task SendPosition(int left, int top)
        {
            //Hubs o concentradores son la clave
            // Clients da la funcionalidad a quien se desea enviar
            await Clients.Others.SendAsync("ReceivePosition",left,top);
        }
    }
}
