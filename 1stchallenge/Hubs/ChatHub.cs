using Microsoft.AspNetCore.SignalR;

namespace _1stchallenge.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
