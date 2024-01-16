using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u22749472_HW01.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientFullName { get; set; }
        public int PatientPhone { get; set; }
        public string PatientAddress { get; set; }
    }
}