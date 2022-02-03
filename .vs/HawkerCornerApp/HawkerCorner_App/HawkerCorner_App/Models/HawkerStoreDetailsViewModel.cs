using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using HawkerCorner_App.DAL;

namespace HawkerCorner_App.Models
{
    public class HawkerStoreDetailsViewModel
    {

        // ==================================
        // Hawker Centre
        // ==================================
        //Centre ID
        [Display(Name = "Centre ID")]
        public string CentreID { get; set; }


        //Name
        [Display(Name = "Centre Name")]
        public string CentreName { get; set; }


        //Address
        [Display(Name = "Address")]
        public string Address { get; set; }

        // =============================
        // Hawker Store
        // ==================================
        //Store ID
        [Display(Name = "Store ID")]
        public string StoreID { get; set; }


        //Average Rating
        [Display(Name = "Average Rating")]
        public int AVGRating { get; set; }


        //Name
        [Display(Name = "Store Name")]
        public string StoreName { get; set; }

        //// ==================================
        //// Review
        //// ==================================
        [Display(Name = "Reviews")]
        public List<Review> ReviewList { get; set; }


    }
}
