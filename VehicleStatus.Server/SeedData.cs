using VehicleStatus.Server.Models;

namespace VehicleStatus.Server
{
    public static class SeedData
    {
        //seeding the data
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                CustomerId = 1,
                Name = "Super Man",
                Address = "nickelgränd 10",
                Vehicles = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = 1,
                        RegNo = "ABC123",
                        ConnectionStatus = "Connected"
                    },
                    new Vehicle
                    {
                        VehicleId = 2,
                        RegNo = "DEF456",
                        ConnectionStatus = "Disconnected"
                    }
                }
            },
            new Customer{
                CustomerId = 2,
                Name = "Spider Man",
                Address = "nickelgränd 11",
                Vehicles = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = 3,
                        RegNo = "GHI789",
                        ConnectionStatus = "Connected"
                    },
                    new Vehicle
                    {
                        VehicleId = 4,
                        RegNo = "JKL012",
                        ConnectionStatus = "Disconnected"
                    }
                }
            }
        };
    }
}