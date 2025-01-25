namespace VehicleStatus.Server.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}