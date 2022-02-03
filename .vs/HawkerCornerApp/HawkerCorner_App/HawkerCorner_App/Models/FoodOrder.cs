using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HawkerCorner_App.Models
{
    public class FoodOrder
    {
        //Order ID
        [Display(Name = "Order ID")]
        public string OrderID { get; set; }


        //User ID
        [Display(Name = "User ID")]
        public string UserID { get; set; }

        //Deliverer ID
        [Display(Name = "Deliverer ID")]
        public string DelivererID { get; set; }

        //Store ID
        [Display(Name = "Store ID")]
        public string StoreID { get; set; }


        //Address
        [Display(Name = "Address")]
        public string Address { get; set; }


        //Order List
        [Display(Name = "Order List")]
        public string OrderList { get; set; }


        //Date
        [Display(Name = "Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime Date { get; set; }


        //Order Confirmation
        [Display(Name = "Order Confirmation")]
        public string OrderConfirm { get; set; }


        //Order Completion
        [Display(Name = "Order Completion")]
        public string OrderComplete { get; set; }
    }

}
