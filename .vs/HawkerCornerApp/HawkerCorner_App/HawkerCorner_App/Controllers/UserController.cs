using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using HawkerCorner_App.Models;
using HawkerCorner_App.DAL;
using System.IO;


namespace HawkerCorner_App.Controllers
{
    public class UserController : Controller
    {
        private FoodOrderDAL foodOrderContext = new FoodOrderDAL();

        // Comes here after RedirectToAction("Index", "User") in HomeController
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Role") == "Customer")
            {
                return View("Orders");
            }
            else //if (HttpContext.Session.GetString("Role") == "Deliverer")
            {
                return RedirectToAction("Index", "DelivererController");
            }
        }
    }

}
