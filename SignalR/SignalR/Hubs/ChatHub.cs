using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class ChatHub: Hub
    {
        public void send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }

        /// <summary>
        /// Join Group Chat.
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public Task JoinGroupChat(string groupName)
        {
            return Groups.Add(Context.ConnectionId, groupName);
        }

        /// <summary>
        /// Leave group Chat.
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public Task LeaveGroupChat(string groupName)
        {
            return Groups.Remove(Context.ConnectionId, groupName);
        }

        /// <summary>
        /// Send Message to All other Users in the group.
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="message"></param>
        public void SendGroupMessage(string groupName, string message, string userName)
        {
            Clients.Group(groupName).SendMessage(userName, message);
        }

        /// <summary>
        /// Send Message To All Users in a Group.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="message"></param>
        public void SendMessageToUser(string userName, string message)
        {
            Clients.User(userName).SendMessage(message);
        }
    }
}