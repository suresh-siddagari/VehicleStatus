namespace VehicleStatus.Server.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string RegNo { get; set; } = "";
        public string ConnectionStatus { get; set; } = "";
    }
}