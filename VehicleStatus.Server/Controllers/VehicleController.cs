using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleStatus.Server.Interfaces;
using VehicleStatus.Server.Models;

namespace VehicleStatus.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet(Name = "GetVehicles")]
        public List<VehicelCustomerDTO> Get()
        {
            return _vehicleService.GetVehiclesWithCustomer();
        }
    }
}