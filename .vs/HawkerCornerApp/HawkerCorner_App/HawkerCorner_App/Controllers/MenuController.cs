using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HawkerCorner_App.DAL;
using HawkerCorner_App.Models;

namespace HawkerCorner_App.Controllers
{
    public class MenuController : Controller
    {
        private HawkerStoreDAL storeContext = new HawkerStoreDAL();
        private HawkerCentreDAL centreContext = new HawkerCentreDAL();
        private ReviewDAL reviewContext = new ReviewDAL();
        private FoodOrderDAL foodOrderContext = new FoodOrderDAL();

        public IActionResult Index()
        {
            List<HawkerStore> storeList = storeContext.GetAllStores();
            return View(storeList);
        }
        public ActionResult StarBuy()
        {
            return View();
        }
        public ActionResult DiscoverNew()
        {
            return View();
        }
        public ActionResult DiscoverNearYou()
        {
            return View();
        }

        // GET: MenuController/Details/5
        public ActionResult ViewStoreDetails(string storeID, string centreID)
        {
            // Return the view for that store
            var sd = new HawkerStoreDetailsViewModel();
            sd.StoreID = storeID;
            sd.CentreID = centreID;

            // Run DAL to get the information for store.
            sd.StoreName = storeContext.GetDetails(storeID).Name;
            sd.AVGRating = storeContext.GetDetails(storeID).AVGRating;

            sd.CentreName = centreContext.GetHawkerCentreDetails(centreID).Name;
            sd.Address = centreContext.GetHawkerCentreDetails(centreID).Address;

            sd.ReviewList = reviewContext.GetAllReviews(storeID);
            return View("HawkerStoreDetails", sd);
        }

        //Order Start
        public ActionResult StartOrder()
        {
            return View("OrderForm");
        }

        [HttpPost]
        public ActionResult OrderForm(Models.FoodOrder formData)
        {
            FoodOrder fo = new FoodOrder();

            //Do something with formData
            fo.OrderID = "O001";  // !!!! CANNOT HARDCODE
            fo.UserID = "U001";   // !!!! CANNOT HARDCODE
            fo.DelivererID = null;
            fo.StoreID = "S001";   // !!!! CANNOT HARDCODE
            fo.Address = formData.Address;
            fo.OrderList = formData.OrderList;
            fo.Date = DateTime.Now;
            fo.OrderConfirm = "Unconfirmed";
            fo.OrderComplete = "Incomplete";

            //Run DAL to add
            foodOrderContext.AddFoodOrder(fo);

            return View(); // Go to payment screen(?)
        }

        private List<HawkerStore> GetAllStores()
        {
            // Get a list of branches from database
            List<HawkerStore> storeList = storeContext.GetAllStores();
            // Adding a select prompt at the first row of the branch list
            storeList.Insert(0, new HawkerStore
            {
                StoreID = "Enter ID",
                Name = "Enter Name"
            });
            return storeList;
        }
    }
}
