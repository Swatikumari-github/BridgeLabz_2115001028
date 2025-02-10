using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    

    // Abstract class for Vehicle
    abstract class Vehicle
    {
        protected string vehicleId;
        protected string driverName;
        protected double ratePerKm;

        public Vehicle(string vehicleId, string driverName, double ratePerKm)
        {
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
        }

        public void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {vehicleId}, Driver: {driverName}, Rate per Km: {ratePerKm}");
        }

        public abstract double CalculateFare(double distance);
    }

    // Interface for GPS
    interface IGPS
    {
        void GetCurrentLocation();
        void UpdateLocation(string location);
    }

    // Car subclass
    class Car : Vehicle, IGPS
    {
        public Car(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Fetching car's current location...");
        }

        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Car location updated to: {location}");
        }
    }

    // Bike subclass
    class Bike : Vehicle, IGPS
    {
        public Bike(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm * 0.8; // Discounted rate for bikes
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Fetching bike's current location...");
        }

        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Bike location updated to: {location}");
        }
    }

    // Auto subclass
    class Auto : Vehicle, IGPS
    {
        public Auto(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm * 0.9; // Slightly discounted rate for autos
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Fetching auto-rickshaw's current location...");
        }

        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Auto location updated to: {location}");
        }
    }

    class RideHailing
    {
        static void Main()
        {
            List<Vehicle> rides = new List<Vehicle>();

            Console.WriteLine("Enter Vehicle Type (1 for Car, 2 for Bike, 3 for Auto): ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Vehicle ID: ");
            string vehicleId = Console.ReadLine();

            Console.Write("Enter Driver Name: ");
            string driverName = Console.ReadLine();

            Console.Write("Enter Rate per Km: ");
            double ratePerKm = double.Parse(Console.ReadLine());

            Vehicle vehicle;

            switch (choice)
            {
                case 1:
                    vehicle = new Car(vehicleId, driverName, ratePerKm);
                    break;
                case 2:
                    vehicle = new Bike(vehicleId, driverName, ratePerKm);
                    break;
                case 3:
                    vehicle = new Auto(vehicleId, driverName, ratePerKm);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            rides.Add(vehicle);
            vehicle.GetVehicleDetails();

            Console.Write("Enter distance traveled (in km): ");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine($"Total Fare: {vehicle.CalculateFare(distance)}");

            if (vehicle is IGPS gpsEnabledVehicle)
            {
                gpsEnabledVehicle.GetCurrentLocation();
                Console.Write("Enter new location to update: ");
                string newLocation = Console.ReadLine();
                gpsEnabledVehicle.UpdateLocation(newLocation);
            }
        }
    }
}
