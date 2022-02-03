using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HawkerCorner_App.Models
{
    public class HawkerStore
    {
        //Centre ID
        [Display(Name = "Centre ID")]
        public string CentreID { get; set; }


        //Store ID
        [Display(Name = "Store ID")]
        public string StoreID { get; set; }


        //Average Rating
        [Display(Name = "Average Rating")]
        public int AVGRating { get; set; }


        //Name
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
