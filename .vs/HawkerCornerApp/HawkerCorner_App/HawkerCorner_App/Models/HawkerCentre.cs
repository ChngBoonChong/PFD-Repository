using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HawkerCorner_App.Models
{
    public class HawkerCentre
    {
        //Centre ID
        [Display(Name = "Centre ID")]
        public string CentreID { get; set; }


        //Name
        [Display(Name = "Name")]
        public string Name { get; set; }


        //Address
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}
