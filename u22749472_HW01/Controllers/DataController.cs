using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using u22749472_HW01.Models;

namespace u22749472_HW01.Controllers
{
    public class DataController : Controller
    {
        static List<Driver> drivers = new List<Driver>()
        {

        };
        // GET: Data
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult SOSConfirmation()
        {
            return View();
        }

        public ActionResult SelectServices()
        {
            List<Services> serv = DataRepository.GetServices();
            return View(serv);
        }

        public ActionResult BookingForm(int? serviceId, string servicename)
        {
            ViewBag.serviceId = serviceId;
            ViewBag.servicename = servicename;
            var viewmodel = new DataViewModel
            {
                Bookings = DataRepository.GetBookings(),
                Services = DataRepository.GetServices(),
                Drivers = DataRepository.GetDrivers(),
                Vehicles = DataRepository.GetVehicles(),
            };
            return View(viewmodel);

        }

        public ActionResult BookingConfirmation()
        {
            return View();
        }

        public ActionResult Ride()
        { 
            return View(); 
        }

        public ActionResult Manage()
        {
            var viewmodel = new DataViewModel
            {
                Services = DataRepository.GetServices(),
                Drivers = DataRepository.GetDrivers(),
                Vehicles = DataRepository.GetVehicles(),
            };
            return View(viewmodel);
        }

        [HttpGet]
        public ActionResult createdriver()
        {
            var viewModel = new DataViewModel
            {
                Services = DataRepository.GetServices()
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult createdriver(Driver d)
        {
            //Add driver to existing list of drivers
            List<Driver> drivers = DataRepository.GetDrivers();
            drivers.Add(d);

            var viewModel = new DataViewModel
            {
                Drivers = drivers,
                Vehicles = DataRepository.GetVehicles(),
                Services = DataRepository.GetServices()
            };
            return View("Manage", viewModel);     
        }

        public ActionResult Index()
        {
            var viewmodel = new DataViewModel
            {
                Bookings = DataRepository.GetBookings(),
                Services = DataRepository.GetServices(),
                Drivers = DataRepository.GetDrivers(),
                Vehicles = DataRepository.GetVehicles(),
            };
            return View(viewmodel);
        }

        public ActionResult GetDriverByService(string  servicetype)
        {
            var drivers = DataRepository.GetDrivers()
            .Where(d => d.ServiceType == servicetype)
            .Select(d => new { d.Id, d.DriverFirstName,d.DriverLastName, d.DriverPhone });

            var driverids = new List<int>();
            var driverfirstnames = new List<string>();
            var driverlastnames = new List<string>();
            var driverphone = new List<string>();
            foreach (var driver in drivers) 
            {
                driverids.Add(driver.Id);
                driverfirstnames.Add(driver.DriverFirstName);
                driverlastnames.Add(driver.DriverLastName);
                driverphone.Add(driver.DriverPhone);
            }
            
            return Content(
                string.Format("{0};{1}", string.Join(",", driverids), string.Join(",", driverfirstnames), string.Join(",",driverlastnames),
                string.Join(",", driverphone)),"text/plain");
        }

        public ActionResult GetVehicleByService(string servicetype) 
        {
            var vehicles = DataRepository.GetVehicles()
            .Where(v => v.ServiceType == servicetype)
            .Select(v => new { v.Id, v.VehicleRegistration });

            var vehicleids = new List<int>();
            var vehicletype = new List<string>();
            var vehicleregistrations = new List<string>();
            foreach (var vehicle in vehicles)
            {
                vehicleids.Add(vehicle.Id);
                vehicletype.Add(vehicle.VehicleRegistration);
                vehicleregistrations.Add(vehicle.VehicleRegistration);
            }
            return Content(
                string.Format("{0};{1}", string.Join(",", vehicleids), string.Join(",",vehicletype),string.Join(",", vehicleregistrations))
                , "text/plain");
        }
    }
}