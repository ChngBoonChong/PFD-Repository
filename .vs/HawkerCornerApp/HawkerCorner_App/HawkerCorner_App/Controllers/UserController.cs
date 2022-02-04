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
        private UsersDAL userContext = new UsersDAL();

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

        public ActionResult Edit(string id)
        {
            // Stop accessing the action if not logged in
            // or account not in the "Staff" role
            if ((HttpContext.Session.GetString("Role") == null) ||
            (HttpContext.Session.GetString("Role") != "Customer") ||
            (HttpContext.Session.GetString("Role") != "Deliverer"))
            {
                return RedirectToAction("Index", "Home");
            }
            if (id == null)
            { //Query string parameter not provided
              //Return to listing page, not allowed to edit
                return RedirectToAction("Index");
            }
            //ViewData["BranchList"] = GetAllBranches();
            Users user = userContext.GetDetails(id);
            if (user == null)
            {
                //Return to listing page, not allowed to edit
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // POST: StaffController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Users ID)
        {
            if (ModelState.IsValid)
            {
                //Update staff record to database
                userContext.Update(ID);
                return RedirectToAction("Index");
            }
            else
            {
                //Input validation fails, return to the view
                //to display error message
                return View(ID);
            }
        }
    }

}
