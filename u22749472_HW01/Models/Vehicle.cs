using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Xml.Linq;

namespace u22749472_HW01.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Display(Name = "Vehicle Type")] //decorator
        public string VehicleType { get; set; }

        [Display(Name = "Vehicle Registration")] //decorator
        public string VehicleRegistration { get; set; }

        [Display(Name = "Vehicle Image")] //decorator
        public Uri VehicleImage { get; set; }
        public string ServiceType { get; set; }
    }
}