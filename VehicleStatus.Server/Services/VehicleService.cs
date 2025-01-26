using VehicleStatus.Server.Interfaces;
using VehicleStatus.Server.Models;

namespace VehicleStatus.Server.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly ILogger<VehicleService> _logger;
      
        private readonly List<Customer> _customers;


        public VehicleService(ILogger<VehicleService> logger)
        {
            _logger = logger;
            _customers = SeedData.Customers;
          
            
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public List<VehicelCustomerDTO> GetVehiclesWithCustomer()
        {
            var vehicles = new List<VehicelCustomerDTO>();
            foreach (var customer in _customers)
            {
                foreach (var vehicle in customer.Vehicles)
                {
                    vehicles.Add(new VehicelCustomerDTO
                    {
                        CustomerId = customer.CustomerId,
                        CustomerName = customer.Name,
                        VehicleId = vehicle.VehicleId,
                        RegNo = vehicle.RegNo,
                        ConnectionStatus = vehicle.ConnectionStatus,
                        CustomerAddress = customer.Address
                    });
                }
            }
            return vehicles;
        }
    }
}