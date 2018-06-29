using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VehicleApp.MvcWebUI.Models;

namespace VehicleApp.MvcWebUI.Controllers
{
    public class VehicleController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        // GET
        public IActionResult List(int? id)
        {

            var vehicles = VehicleRepository.Vehicles;
            if (id != null)
            {
                vehicles = vehicles.Where(i => i.CategoryId == id).ToList();
            }

            return View(vehicles);
        }
        
    }
}