using IntelliCollabUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntelliCollabUI.Controllers
{
    public class LogInController : Controller
    {
        public ActionResult LogIn()
        {
            ViewBag.IsLogInOrRegPg = true;
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(string email, string password)
        {

            if (email == "k@gmail.com" && password == "123")
            {
                Session["UserID"] = email;
                return RedirectToAction("Index", "DashBoard");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View();
            }


        }


        public ActionResult Registration()
        {
            ViewBag.IsLogInOrRegPg = true;
            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.IsLogInOrRegPg = true;
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string email, string password)
        {
            if(email =="abc@gmail.com")
            {
                ViewBag.Message = "Create successfully";
                ViewBag.ErrorMessage = null;
            }
            else
            {
                ViewBag.Message = null;
                ViewBag.ErrorMessage = "Fake email";
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                string jsonString = collection["profileData"];
                dynamic obj = JsonConvert.DeserializeObject<UserProfile>(jsonString);
                HttpPostedFileBase file = Request.Files["UploadImg"];
                if(file != null && file.ContentLength>0)
                {
                    using (var reader = new BinaryReader(file.InputStream))
                    {
                        byte[] fileContent = reader.ReadBytes(file.ContentLength);

                        // Assuming you have a connection string in your web.config
                        //using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString))
                        //{
                        //    connection.Open();

                        //    string insertQuery = "INSERT INTO YourTable (FileName, FileContent) VALUES (@FileName, @FileContent)";

                        //    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        //    {
                        //        command.Parameters.AddWithValue("@FileName", file.FileName);
                        //        command.Parameters.AddWithValue("@FileContent", fileContent);

                        //        command.ExecuteNonQuery();
                        //    }
                        //}
                    }
                }
                return RedirectToAction("LogIn");
            }
            catch(Exception ex)
            {
                return View();
            }
        }
    }
}
