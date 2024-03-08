using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntelliCollabUI.Controllers
{
    public class UserManagementController : Controller
    {
        // GET: UserManagement
        public ActionResult Attendance()
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }

        public ActionResult NoticeBoard()
        {
            return View();
        }

        public ActionResult DigitalLibraryBoard()
        {
            return View();
        }
        public ActionResult Results()
        {
            return View();
        }

        public ActionResult CalendarView()
        {
            return View();
        }

        public ActionResult PersonalInfo()
        {
            return View();
        }
    }
}