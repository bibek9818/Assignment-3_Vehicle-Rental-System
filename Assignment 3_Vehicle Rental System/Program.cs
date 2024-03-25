using Assignment_3_Vehicle_Rental_System;
using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
 

        Car car = new Car
        {
            Model = "Toyota Camry",
            Manufacturer = "Toyota",
            Year = 2022,
            RentalPrice = 50,
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
            RentalPrice = 80,
            Capacity = 4,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Honda CBR500R",
            Manufacturer = "Honda",
            Year = 2019,
            RentalPrice = 30,
            EngineCapacity = 500,
            FuelType = "Gasoline",
            HasFairing = true
        };



        Console.WriteLine("Details of vehicles in fleet:");
  

       
    }
}


