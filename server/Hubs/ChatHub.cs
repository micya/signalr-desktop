using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace server.Hubs
{
    public class ChatHub : Hub
    {
        // public Task BroadcastMessage(string name, string message) =>
        //     Clients.All.SendAsync("broadcastMessage", name, message);

        // public Task Echo(string name, string message) =>
        //     Clients.Client(Context.ConnectionId)
        //            .SendAsync("echo", name, $"{message} (echo from server)");

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}