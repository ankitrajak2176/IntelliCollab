﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntelliCollabUI.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentInfo()
        {
            return View();
        }
    }
}