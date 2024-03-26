using Assignment_3_Vehicle_Rental_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Vehicle_Rental_System
{


    public class RentalAgency
    {
        private Vehicle[] Fleet { get; set; }
        public double TotalRevenue { get; private set; }

        public RentalAgency(int capacity)
        {
            Fleet = new Vehicle[capacity];
        }

        public void AddVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] == null)
                {
                    Fleet[i] = vehicle;
                    return;
                }
            }
            Console.WriteLine("Fleet is full, cannot add more vehicles.");
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] == vehicle)
                {
                    Fleet[i] = null;
                    return;
                }
            }
            Console.WriteLine("Vehicle not found in the fleet.");
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            if (Array.Exists(Fleet, v => v == vehicle))
            {
                double rentalCost = days * vehicle.RentalPrice;
                TotalRevenue += rentalCost;
                Console.WriteLine($"Vehicle rented for {days} days. Total cost: {rentalCost}");
            }
            else
            {
                Console.WriteLine("Vehicle not available for rent.");
            }
        }

        public Vehicle[] GetFleet()
        {
            return Fleet;
        }
    }





}



