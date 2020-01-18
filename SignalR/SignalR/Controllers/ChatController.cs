using System.Collections.Generic;
using System.Web.Mvc;

namespace SignalR.Controllers
{
    public class ChatController : Controller
    {
        private List<string> Groups = new List<string> { "Xamarin", "Azure", };
        // GET: Chat
        //public ActionResult Index()
        //{
        //    return View();
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(Groups);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public ActionResult GroupChat(string groupName, string userName)
        {
            ViewBag.GroupName = groupName;
            ViewBag.UserName = userName;

            return View();
        }
    }
}