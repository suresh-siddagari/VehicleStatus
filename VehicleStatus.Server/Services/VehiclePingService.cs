using System;
using System.Reactive.Linq;
using VehicleStatus.Server.Interfaces;
using VehicleStatus.Server.Models;

namespace VehicleStatus.Server.Services
{
    public class VehiclePingService : IVehiclePingService
    {
        private readonly IVehicleService _vehicleService;

        public VehiclePingService(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
            this.StartPing();
        }

        //simulating a ping to the vehicle
        public void StartPing()
        {
            //get list of vehicles
            var vehicles = _vehicleService.GetVehiclesWithCustomer();
            foreach (var vehicle in vehicles)
            {
                Observable.Interval(TimeSpan.FromMinutes(1))
                    .Subscribe(x =>
                    {
                        //get seeded data
                        SeedData.Customers.ForEach(c =>
                        {
                            c.Vehicles.ForEach(v =>
                            {
                                if (v.VehicleId == vehicle.VehicleId)
                                {
                                    v.ConnectionStatus = GetRandomStatus();
                                }
                            });
                        });
                        
                    });
            }
        }

        private string GetRandomStatus()
        {
            var random = new Random();
            var status = random.Next(0, 2);
            return status == 0 ? "Connected" : "";
        }
    }
}