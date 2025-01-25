using VehicleStatus.Server.Models;

namespace VehicleStatus.Server
{
    public interface IVehicleService
    {
        public List<Customer> GetCustomers();

         public List<VehicelCustomerDTO> GetVehiclesWithCustomer();
    }
}