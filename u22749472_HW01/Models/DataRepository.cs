using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u22749472_HW01.Models
{
    public class DataRepository
    {
        public static List<Booking> GetBookings()
        {
            List<Booking> booking = new List<Booking>();

            booking.Add(
                new Booking{
                    Id = 1
                   
                }
                );
            return booking;
        }

        public static List<Services> GetServices() 
        {
            List<Services> services = new List<Services>();

            services.Add(
                new Services{
                    Id = 1,
                    serviceimage = new Uri("https://cdn.pixabay.com/photo/2016/09/01/10/33/witchs-house-1635770_960_720.jpg") ,
                    Servicetype = "ALS (Advances Life Support)",
                    ServiceDesc = "ALS ambulance is staffed by a Paramedic and is used to trasder patients who require high level care."
                }
                );
            services.Add(
                new Services
                {
                    Id = 2,
                    serviceimage = new Uri("https://www.google.com/search?tbm=isch&q=hospital%20service%20image&tbs=imgo:1#imgrc=-o0811vWeDrktM"),
                    Servicetype = "BLS (Basic Life Support)",
                    ServiceDesc = "BLS ambulance provides transport to patients who are in non life threatning condition"
                }
                );
            services.Add(
                new Services
                {
                    Id = 3,
                    serviceimage = new Uri("https://www.google.com/search?tbm=isch&q=hospital%20service%20image&tbs=imgo:1#imgrc=-o0811vWeDrktM"),
                    Servicetype = "Patient Transport",
                    ServiceDesc = "The most basic type of trasnport for patients requireing ambulatory support to and from the hospital."
                }
                );
            services.Add(
                new Services
                {
                    Id = 4,
                    serviceimage = new Uri("https://www.google.com/search?tbm=isch&q=hospital%20service%20image&tbs=imgo:1#imgrc=-o0811vWeDrktM"),
                    Servicetype = "Medical Utility Vehicle",
                    ServiceDesc = "A state-of-the-art small of large van that is designed to facilitate the movement and transport of patients."
                }
                );
            services.Add(
                new Services
                {
                    Id = 5,
                    serviceimage = new Uri("https://www.google.com/search?tbm=isch&q=hospital%20service%20image&tbs=imgo:1#imgrc=-o0811vWeDrktM"),
                    Servicetype = "Event Medical Ambulance",
                    ServiceDesc = "Ambulances that are stationed at events such as concerts, sports games, and festivals."
                }
                );
            services.Add(
                new Services
                {
                    Id = 6,
                    serviceimage = new Uri("https://www.google.com/search?tbm=isch&q=hospital%20service%20image&tbs=imgo:1#imgrc=-o0811vWeDrktM"),
                    Servicetype = "Air Ambulance",
                    ServiceDesc = "Air ambulance help in the trasnfer of patients across long distances in both emergency and non-emergency situations."
                }
                );
            return services;
        }
        public static List<Driver> GetDrivers() 
        {
            return new List<Driver>
            {
                new Driver{Id = 1, 
                    DriverImage = new Uri("https://www.google.com/search?tbm=isch&q=image%20icon%20for%20a%20driver&tbs=imgo:1#imgrc=dQest0D53GJEKM") ,
                    DriverFirstName = "Jackson",
                    DriverLastName = "Steele",
                    DriverPhone = "0851234567", 
                    ServiceType = "ALS (Advances Life Support)" },
                new Driver{Id = 2, 
                    DriverImage = new Uri("https://www.google.com/search?tbm=isch&q=image%20icon%20for%20a%20driver&tbs=imgo:1#imgrc=dQest0D53GJEKM") ,
                    DriverFirstName = "Ava  ",
                    DriverLastName = "Summers",
                    DriverPhone = "0885557890",
                    ServiceType = "ALS (Advances Life Support)"},
                new Driver{Id = 3,
                    DriverImage = new Uri("https://www.google.com/search?tbm=isch&q=image%20icon%20for%20a%20driver&tbs=imgo:1#imgrc=dQest0D53GJEKM") ,
                    DriverFirstName = "Max  ",
                    DriverLastName = "Rivera",
                    DriverPhone = "0834567890",
                    ServiceType = "BLS (Basic Life Support)" },
                new Driver{Id = 4, 
                    DriverImage = new Uri("https://www.google.com/search?tbm=isch&q=image%20icon%20for%20a%20driver&tbs=imgo:1#imgrc=dQest0D53GJEKM") ,
                    DriverFirstName = "Olivia  ",
                    DriverLastName = "Knight",
                    DriverPhone = "0876543210",
                    ServiceType = "BLS (Basic Life Support)" },
                new Driver{Id = 5, 
                    DriverImage = new Uri("https://www.google.com/search?tbm=isch&q=image%20icon%20for%20a%20driver&tbs=imgo:1#imgrc=dQest0D53GJEKM") ,
                    DriverFirstName = "Ethan  ",
                    DriverLastName = "Blackwood",
                    DriverPhone = "0658889999", 
                    ServiceType = "Patient Transport" },
                new Driver{Id = 6,
                    DriverImage = new Uri("https://www.google.com/search?tbm=isch&q=image%20icon%20for%20a%20driver&tbs=imgo:1#imgrc=dQest0D53GJEKM") ,
                    DriverFirstName = "Noah  ",
                    DriverLastName = "Montgomery",
                    DriverPhone = "08316549870",
                    ServiceType = "Patient Transport" },
                new Driver{Id = 7, 
                    DriverImage = new Uri("https://www.google.com/search?tbm=isch&q=image%20icon%20for%20a%20driver&tbs=imgo:1#imgrc=dQest0D53GJEKM") ,
                    DriverFirstName = "Lily  ",
                    DriverLastName = "Thompson",
                    DriverPhone = "7772223333",
                    ServiceType = "Medical Utility Vehicle" },
                new Driver{Id = 8, 
                    DriverImage = new Uri("https://www.google.com/search?tbm=isch&q=image%20icon%20for%20a%20driver&tbs=imgo:1#imgrc=dQest0D53GJEKM") ,
                    DriverFirstName = "Lucas  ",
                    DriverLastName = "Harrington",
                    DriverPhone = "0890001111", 
                    ServiceType = "Event Medical Ambulance" },
                new Driver{Id = 9, 
                    DriverImage = new Uri("https://www.google.com/search?tbm=isch&q=image%20icon%20for%20a%20driver&tbs=imgo:1#imgrc=dQest0D53GJEKM") ,
                    DriverFirstName = "Sophia  ",
                    DriverLastName = "Cruz",
                    DriverPhone = "0884447777",
                    ServiceType = "Event Medical Ambulance" },
                new Driver{Id = 10, 
                    DriverImage = new Uri("https://www.google.com/search?tbm=isch&q=image%20icon%20for%20a%20driver&tbs=imgo:1#imgrc=dQest0D53GJEKM") ,
                    DriverFirstName = "Mia  ",
                    DriverLastName = "Parker",
                    DriverPhone = "0557772222", 
                    ServiceType = "Air Ambulance" },    
            };
        }

        public static List<Vehicle> GetVehicles() 
        {
            return new List<Vehicle>
            {
                new Vehicle{Id = 1, 
                    VehicleImage = new Uri ("https://za.pinterest.com/pin/ambulance-car-clipart-vector-ambulance-car-icon-design-illustration-car-icons-ambulance-icons-ambulance-clipart-png-image-for-free-download--1086986060032789873/"),
                    VehicleType = "Type 1",
                    VehicleRegistration = "CAH 1234 GP", 
                    ServiceType = "ALS (Advances Life Support)"},
                new Vehicle{Id = 2, 
                    VehicleImage = new Uri("https://za.pinterest.com/pin/ambulance-car-clipart-vector-ambulance-car-icon-design-illustration-car-icons-ambulance-icons-ambulance-clipart-png-image-for-free-download--1086986060032789873/"),
                    VehicleType = "Type 1",
                    VehicleRegistration = "BDM 5678 EC",
                    ServiceType = "ALS (Advances Life Support)"},
                new Vehicle{Id = 3, 
                    VehicleImage = new Uri("https://za.pinterest.com/pin/ambulance-car-clipart-vector-ambulance-car-icon-design-illustration-car-icons-ambulance-icons-ambulance-clipart-png-image-for-free-download--1086986060032789873/"),
                    VehicleType = "Type 2",
                    VehicleRegistration = "FGX 9012 MP",
                    ServiceType = "BLS (Basic Life Support)"},
                new Vehicle{Id = 4, 
                    VehicleImage = new Uri("https://za.pinterest.com/pin/ambulance-car-clipart-vector-ambulance-car-icon-design-illustration-car-icons-ambulance-icons-ambulance-clipart-png-image-for-free-download--1086986060032789873/"),
                    VehicleType = "Type 2",
                    VehicleRegistration = "JKL 3456 NW",
                    ServiceType = "BLS (Basic Life Support)"},
                new Vehicle{Id = 5, 
                    VehicleImage = new Uri("https://za.pinterest.com/pin/ambulance-car-clipart-vector-ambulance-car-icon-design-illustration-car-icons-ambulance-icons-ambulance-clipart-png-image-for-free-download--1086986060032789873/"),
                    VehicleType = "Type 3",
                    VehicleRegistration = "RST 7890 WC",
                    ServiceType = "Patient Transport"},
                new Vehicle{Id = 6, 
                    VehicleImage = new Uri("https://za.pinterest.com/pin/ambulance-car-clipart-vector-ambulance-car-icon-design-illustration-car-icons-ambulance-icons-ambulance-clipart-png-image-for-free-download--1086986060032789873/"),
                    VehicleType = "Type 3",
                    VehicleRegistration = "XYZ 2345 FS",
                    ServiceType = "Patient Transport",},
                new Vehicle{Id = 7, 
                    VehicleImage = new Uri("https://za.pinterest.com/pin/ambulance-car-clipart-vector-ambulance-car-icon-design-illustration-car-icons-ambulance-icons-ambulance-clipart-png-image-for-free-download--1086986060032789873/"),
                    VehicleType = "Type 4",
                    VehicleRegistration = "UVW 6789 LP",
                    ServiceType = "Medical Utility Vehicle"},
                new Vehicle{Id = 8, 
                    VehicleImage = new Uri("https://za.pinterest.com/pin/ambulance-car-clipart-vector-ambulance-car-icon-design-illustration-car-icons-ambulance-icons-ambulance-clipart-png-image-for-free-download--1086986060032789873/"),
                    VehicleType = "Type 5",
                    VehicleRegistration = "MNO 0123 EC",
                    ServiceType = "Event Medical Ambulance"},
                new Vehicle{Id = 9, 
                    VehicleImage = new Uri("https://za.pinterest.com/pin/ambulance-car-clipart-vector-ambulance-car-icon-design-illustration-car-icons-ambulance-icons-ambulance-clipart-png-image-for-free-download--1086986060032789873/"),
                    VehicleType = "Type 5",
                    VehicleRegistration = "QWE 4567 GT", 
                    ServiceType = "Event Medical Ambulance"},
                new Vehicle{Id = 10, 
                    VehicleImage = new Uri("https://za.pinterest.com/pin/ambulance-car-clipart-vector-ambulance-car-icon-design-illustration-car-icons-ambulance-icons-ambulance-clipart-png-image-for-free-download--1086986060032789873/"),
                    VehicleType = "Type 6",
                    VehicleRegistration = "TYU 8901 NC",
                    ServiceType = "Air Ambulance"},
            };
        }
    }
}