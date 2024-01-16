using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u22749472_HW01.Models
{
    public class DataViewModel
    {
        public int selectedServiceType { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Services> Services { get; set; }
    }
}