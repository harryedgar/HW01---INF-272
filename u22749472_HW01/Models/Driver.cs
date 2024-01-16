using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Xml.Linq;

namespace u22749472_HW01.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string DriverFirstName { get; set; }
        public string DriverLastName { get; set; }
        public string DriverPhone { get; set; }
        public Uri DriverImage { get; set; }
        public string ServiceType { get; set; }
    }
}