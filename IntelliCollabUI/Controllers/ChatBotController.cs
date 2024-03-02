using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntelliCollabUI.Controllers
{
    public class ChatBotController : Controller
    {
        // GET: ChatBot
        public ActionResult Bot()
        {
            return View();
        }
    }
}