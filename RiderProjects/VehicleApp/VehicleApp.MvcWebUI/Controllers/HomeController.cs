using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleApp.MvcWebUI.Models;

namespace VehicleApp.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(VehicleRepository.Vehicles);
        }

        public IActionResult Details(int id)
        {
            return View(VehicleRepository.Vehicles.FirstOrDefault(i=> i.Id==id));
        }


    }
}