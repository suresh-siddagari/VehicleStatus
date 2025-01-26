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
                Name = "SA Redivisioning",
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
                        ConnectionStatus = ""
                    }
                }
            },
            new Customer{
                CustomerId = 2,
                Name = "Vällingby Bageri",
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
                        ConnectionStatus = ""
                    }, 
                    new Vehicle
                    {
                        VehicleId = 5,
                        RegNo = "MNO345",
                        ConnectionStatus = ""
                    },
                    new Vehicle
                    {
                        VehicleId = 6,
                        RegNo = "PQR678",
                        ConnectionStatus = "Connected"
                    }, 
                    new Vehicle
                    {
                        VehicleId = 7,
                        RegNo = "STU901",
                        ConnectionStatus = ""
                    }
                }
            }, 
            new Customer{
                CustomerId = 3,
                Name = "Kista Galleria",
                Address = "nickelgränd 12",
                Vehicles = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = 8,
                        RegNo = "VWX234",
                        ConnectionStatus = "Connected"
                    },
                    new Vehicle
                    {
                        VehicleId = 9,
                        RegNo = "YZA567",
                        ConnectionStatus = ""
                    }, 
                    new Vehicle
                    {
                        VehicleId = 10,
                        RegNo = "BCD890",
                        ConnectionStatus = "Connected"
                    },
                }
            }
        };
    }
}