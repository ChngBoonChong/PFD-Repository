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
    public class DelivererController : Controller
    {
        private FoodOrderDAL foodOrderContext = new FoodOrderDAL();

        public IActionResult Index()
        {
            //Get all orders from DAL
            List<FoodOrder> foodOrderList = foodOrderContext.GetAllFoodOrders();

            return View("DelivererIndex", foodOrderList);//foodOrderList
        }

        [HttpGet]
        public ActionResult AcceptOrder(string orderID)
        {
            // FOR NOW, DELETE THIS ONE LINE OF CODE
            HttpContext.Session.SetString("LoginID", "U001");

            // Run DAL to change status
            FoodOrder foodOrder = foodOrderContext.ChangeFoodOrderStatus(orderID, (string)HttpContext.Session.GetString("LoginID"));
            
            // Return the view for that order
            return View("FoodDeliveryDetails", foodOrder);
        }

        [HttpGet]
        public ActionResult CompleteOrder(string orderID)
        {
            // FOR NOW, DELETE THIS ONE LINE OF CODE
            HttpContext.Session.SetString("LoginID", "U001");
            //string testOrderID = "O004";

            // Run DAL to change status
            foodOrderContext.ChangeFoodOrderCompletion(orderID, (string)HttpContext.Session.GetString("LoginID"));

            // Exit to Index once order is completed.
            return RedirectToAction("Index");

        }
    }
}
