using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HawkerCorner_App.DAL;
using HawkerCorner_App.Models;

namespace HawkerCorner_App.Controllers
{
    public class ModeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult UserMode()
        {
            return View();
        }
        public ActionResult DelivererMode()
        {
            return View();
        }
    }
}
