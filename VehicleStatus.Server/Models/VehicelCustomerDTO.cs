namespace VehicleStatus.Server.Models
{
    public class VehicelCustomerDTO
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = "";
        public string CustomerAddress { get; set; } = "";
        public int VehicleId { get; set; }
        public string RegNo { get; set; } = "";
        public string ConnectionStatus { get; set; } = "";
    }
}