using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    public class UserHub: Hub
    {
        public void send(string userId)
        {
            Clients.AllExcept(Context.ConnectionId).userupdated(userId);
        }
    }
}