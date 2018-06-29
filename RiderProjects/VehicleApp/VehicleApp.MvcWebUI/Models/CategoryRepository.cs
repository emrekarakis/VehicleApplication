using System.Collections.Generic;
using System.Linq;

namespace VehicleApp.MvcWebUI.Models
{
    public class CategoryRepository
    {
      private static List<Category> categories = null;
        
        static CategoryRepository()
        {
            categories = new List<Category>()
            {
              new Category(){Id = 1,Name = "Spor Arabaları"},
              new Category(){Id = 2,Name = "Normal Vasıta"},
              new Category(){Id = 3,Name = "Motorlu Vasıta"},
              new Category(){Id = 4,Name = "Yolcu Taşıyan Vasıta"},
              new Category(){Id = 5,Name = "Yük Taşıyan Vasıta"}
           
            };
        }

         

        public static List<Category> Categories
        {
            get
            {
                return categories; 
            }
        }

        public static void AddVehicle(Category category)
        {
            categories.Add(category);
        }
    }
}