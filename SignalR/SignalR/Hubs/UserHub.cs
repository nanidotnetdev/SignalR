using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    public class UserHub: Hub
    {
        public void send(string userId, string connectionId)
        {
            Clients.AllExcept(connectionId).userupdated(userId);
        }
    }
}