namespace VehicleApp.MvcWebUI.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string NickName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ModelYear { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public bool IsActive { get; set; }
        public string Image  { get; set; }
        public int  CategoryId { get; set; }
        public Category Category { get; set; }

    }
}