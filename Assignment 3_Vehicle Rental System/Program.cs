using Assignment_3_Vehicle_Rental_System;
using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency(10);

        Car car = new Car
        {
            Model = "Toyota Camry",
            Manufacturer = "Toyota",
            Year = 2022,
            RentalPrice = 220,
            Seats = 5,
            EngineType = "V6",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "Ford F-150",
            Manufacturer = "Ford",
            Year = 2020,
            RentalPrice = 180,
            Capacity = 4,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Honda CBR500R",
            Manufacturer = "Honda",
            Year = 2019,
            RentalPrice = 330,
            EngineCapacity = 500,
            FuelType = "Gasoline",
            HasFairing = true
        };

        agency.AddVehicle(car);
        agency.AddVehicle(truck);
        agency.AddVehicle(motorcycle);

        Console.WriteLine("Details of vehicles in fleet:");
        foreach (var vehicle in agency.GetFleet())
        {
            if (vehicle != null)
            {
                vehicle.DisplayDetails();
            }
        }

        agency.RentVehicle(car, 3);
        agency.RentVehicle(truck, 5);
        agency.RentVehicle(motorcycle, 2);

        Console.WriteLine($"Total revenue: {agency.TotalRevenue}");
    }
}


