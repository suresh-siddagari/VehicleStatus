using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleStatus.Server.Interfaces;

namespace VehicleStatus.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehiclePingController : ControllerBase
    {
        private readonly IVehiclePingService _vehiclePingService;

        public VehiclePingController(IVehiclePingService vehiclePingService)
        {
            _vehiclePingService = vehiclePingService;
        }

        [HttpGet(Name = "StartPing")]
        public void Get()
        {
            _vehiclePingService.StartPing();
        }
    }
}