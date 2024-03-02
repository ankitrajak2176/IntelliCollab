using IntelliCollabUI.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntelliCollabUI.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LogIn", "LogIn");
            } 
        }

        public void DbconnectionDemo()
        {
            DbConnect conn = null;
            try
            {
                string query = "select * from UserMaster";
                conn  = new DbConnect();
                var s = conn.GetDataFromDB(query);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public ActionResult CalendarView()
        {
            return View();
        }
    }
}