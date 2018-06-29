using System.Collections.Generic;

namespace VehicleApp.MvcWebUI.Models
{
    public class Category
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}