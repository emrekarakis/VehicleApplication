using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VehicleApp.MvcWebUI.Models;

namespace VehicleApp.MvcWebUI.Controllers
{
    public class RecordController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View(VehicleRepository.Vehicles);
        }
        
        [HttpGet]
        public IActionResult Add()
        {
           // var categories = CategoryRepository.Categories;
            //ViewBag.Categories = categories;
            return
                View();
        }
        
        [HttpPost]
        public IActionResult Add(Vehicle vehicle)
        {

            if (vehicle.Type.Equals("1"))
            {
                vehicle.Type = "Otomobil";
            }
            else if(vehicle.Type.Equals("2"))
            {
                vehicle.Type = "Kamyonet";
            }
            else if (vehicle.Type.Equals("3"))
            {
                vehicle.Type = "Kamyon";
            }
            else if(vehicle.Type.Equals("4"))
            {
                vehicle.Type = "Otobüs";
            } 
            else if (vehicle.Type.Equals("5"))
            {
                vehicle.Type = "Motosiklet";
            }


            
            VehicleRepository.AddVehicle(vehicle);
            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View();
            }

            return View("Index",VehicleRepository.Vehicles.Where(i=>i.Brand.Contains(query)||i.Type.Contains(query)||i.NickName.Contains(query)||i.Plate.Contains(query)||i.Model.Contains(query)||i.Color.Contains(query)||i.ModelYear.Contains(query)));
        }
    }
}