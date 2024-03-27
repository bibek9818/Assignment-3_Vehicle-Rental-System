using Assignment_3_Vehicle_Rental_System;


using System;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency(10);

        Car car = new Car
        {
            Model = "Ford Explorer",
            Manufacturer = "Ford",
            Year = 2023,
            RentalPrice = 500,
            Seats = 7,
            EngineType = "V6",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "Toyota Tundra",
            Manufacturer = "Toyota",
            Year = 2022,
            RentalPrice = 600,
            Capacity = 4,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Crossfire RM",
            Manufacturer = "Crossfire",
            Year = 2020,
            RentalPrice = 300,
            EngineCapacity = 250,
            FuelType = "Gasoline",
            HasFairing = true
        };

        agency.AddVehicle(car);
        agency.AddVehicle(truck);
        agency.AddVehicle(motorcycle);

        Console.WriteLine("****** Welcome to the Vehicle Rental Management System ******\n");

        Console.WriteLine("Available Vehicles:");
        Console.WriteLine("--------------------------------------");
        foreach (var vehicle in agency.GetFleet())
        {
            if (vehicle != null)
            {
                vehicle.DisplayDetails();
                Console.WriteLine("--------------------------------------");
            }
        }

        Console.WriteLine("\nRenting Vehicles:");
        Console.WriteLine("--------------------------------------");
        agency.RentVehicle(car, 2);
        agency.RentVehicle(truck, 2);
        agency.RentVehicle(motorcycle, 2);
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"\nTotal revenue: ${agency.TotalRevenue}");
    }
}
