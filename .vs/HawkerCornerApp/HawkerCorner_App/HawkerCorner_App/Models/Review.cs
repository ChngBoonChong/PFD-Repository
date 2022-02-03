using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HawkerCorner_App.Models
{
    public class Review
    {
        //User ID
        [Display(Name = "User ID")]
        public string UserID { get; set; }


        //Review ID
        [Display(Name = "Review ID")]
        public string ReviewID { get; set; }


        //Store ID
        [Display(Name = "Store ID")]
        public string StoreID { get; set; }


        //Description
        [Display(Name = "Description")]
        public string Description { get; set; }


        //Rating
        [Display(Name = "Rating")]
        public int Rating { get; set; }
    }
}
