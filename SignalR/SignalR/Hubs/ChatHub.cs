using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    public class ChatHub: Hub
    {
        public void send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
    }
}