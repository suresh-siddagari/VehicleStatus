using VehicleStatus.Server.Models;

namespace VehicleStatus.Server.Interfaces
{
    public interface IVehicleService
    {
        public List<Customer> GetCustomers();

        public List<VehicelCustomerDTO> GetVehiclesWithCustomer();
    }
}