using Microsoft.AspNetCore.Mvc;
using VehicleApp.MvcWebUI.Models;

namespace VehicleApp.MvcWebUI.ViewComponents
{
    public class MenuViewComponent :ViewComponent
    {


        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }

    }
}