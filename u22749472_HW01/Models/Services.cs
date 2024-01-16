using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace u22749472_HW01.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Servicetype { get; set; }
        public string ServiceDesc { get; set; }
        public Uri serviceimage { get; set; }
        //public List<Services> services { get; set; }

        public Services() 
        { 
        
        }   
    }
}