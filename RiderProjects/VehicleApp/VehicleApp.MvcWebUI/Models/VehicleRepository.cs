using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;

namespace VehicleApp.MvcWebUI.Models
{
    public static class VehicleRepository
    {
        private static List<Vehicle> vehicles = null;
        
        static VehicleRepository()
        {
            vehicles = new List<Vehicle>()
            {
              new Vehicle(){Id = 1,Plate = "07 TBC 95",NickName = "Phoenix",Brand = "Bmw",Model = "Yeni",ModelYear = "1990",Type ="otomobil",Color = "Turuncu",IsActive = true,Image = "1.jpg",CategoryId = 1},
              new Vehicle(){Id = 2,Plate = "08 ASD 12",NickName = "Daredevil",Brand = "Renault",Model = "Eski",ModelYear = "1995",Type ="kamyonet",Color = "Beyaz",IsActive = false,Image = "2.jpg",CategoryId = 5},
              new Vehicle(){Id = 3,Plate = "34 BMW 123",NickName = "FireFox",Brand = "Porche",Model = "Yeni",ModelYear = "1996",Type ="otomobil",Color = "Beyaz",IsActive = true,Image = "3.jpg",CategoryId = 1},
              new Vehicle(){Id = 4,Plate = "32 PD 222",NickName = "Hot cherries",Brand = "Toyota",Model = "Eski",ModelYear = "1997",Type ="otomobil",Color = "Yeşil",IsActive = false,Image = "4.jpg",CategoryId = 2},
              new Vehicle(){Id = 5,Plate = "35 YT 56",NickName = "Ghost",Brand = "Suzuki",Model = "Eski",ModelYear = "1998",Type ="motosiklet",Color = "Siyah",IsActive = true,Image = "5.jpg",CategoryId = 3},
              new Vehicle(){Id = 6,Plate = "38 ER 122",NickName = "Polar bear",Brand = "Wolkswogen",Model = "Yeni",ModelYear = "1999",Type ="kamyon",Color = "Mavi",IsActive = false,Image = "6.jpg",CategoryId = 5},
              new Vehicle(){Id = 7,Plate = "10 AA 11",NickName = "Snowball",Brand = "Ford",Model = "Eski",ModelYear = "2000",Type ="kamyonet",Color = "Beyaz",IsActive = true,Image = "7.jpg",CategoryId = 5},
              new Vehicle(){Id = 8,Plate = "11 BB 12",NickName = "Yang",Brand = "Mercedes",Model = "Yeni",ModelYear = "2005",Type ="otobüs",Color = "Gri",IsActive = false,Image = "8.jpg",CategoryId = 4},
              new Vehicle(){Id = 9,Plate = "12 SDF 123",NickName = "Phantom",Brand = "Ferrari",Model = "Yeni",ModelYear = "2007",Type ="otomobil",Color = "Kırmızı",IsActive = true,Image = "9.jpg",CategoryId = 1}
            };
        }

         

        public static List<Vehicle> Vehicles
        {
            get
            {
                return vehicles; 
            }
        }

        public static void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public static Vehicle GetById(int id)
        {
            return vehicles.FirstOrDefault(i => i.Id == id);
        }

    }
}