using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HawkerCorner_App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HawkerCorner_App.DAL;


namespace HawkerCorner_App.Controllers
{
    public class HomeController : Controller
    {

        private UsersDAL userContext = new UsersDAL();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tool()
        {
            return View();
        }

        public IActionResult LoginView()
        {
            if (HttpContext.Session.GetString("Role") == "User")
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Login(IFormCollection FormData)
        {
            if (HttpContext.Session.GetString("Role") == "User")
            {
                return RedirectToAction("Index", "Home");
            }

            string email = FormData["txtLoginID"].ToString();
            string password = FormData["txtPassword"].ToString();
            DateTime DateTiming = DateTime.Now;

            if (userContext.ValidUserLogin(email, password) == true)
            {
                string Role = Convert.ToString(userContext.GetUserRole(email));
                HttpContext.Session.SetString("Role", Role);
                string userID = Convert.ToString(userContext.GetUserID(email));
                HttpContext.Session.SetString("LoginID", userID);
                ViewData["UserID"] = userID.ToString();
                HttpContext.Session.SetString("LogInTime", DateTiming.ToString());

                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "Invalid Login Credentials";
                return RedirectToAction("LoginView");
            }
        }
        public ActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult ToDel()
        {
            HttpContext.Session.SetString("Role", "Deliverer");
            return RedirectToAction("Index");
        }

        public IActionResult ToUser()
        {
            HttpContext.Session.SetString("Role", "Customer");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
