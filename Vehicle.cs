//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops2
//{
//    using System;

//    class Vehicle
//    {
//        // Static variable shared across all vehicles
//        public static double RegistrationFee = 500.0;

//        // Readonly variable for RegistrationNumber
//        public readonly string RegistrationNumber;

//        // Instance variables
//        public string OwnerName { get; set; }
//        public string VehicleType { get; set; }

//        // Constructor using 'this' to initialize properties
//        public Vehicle(string ownerName, string vehicleType, string registrationNumber)
//        {
//            this.OwnerName = ownerName;
//            this.VehicleType = vehicleType;
//            this.RegistrationNumber = registrationNumber;
//        }

//        // Static method to update registration fee
//        public static void UpdateRegistrationFee(double newFee)
//        {
//            RegistrationFee = newFee;
//            Console.WriteLine($"Registration fee updated to: {RegistrationFee}");
//        }

//        // Method to display vehicle details with 'is' operator check
//        public void DisplayRegistrationDetails(object obj)
//        {
//            if (obj is Vehicle vehicle)
//            {
//                Console.WriteLine($"\nVehicle Registration Details:");
//                Console.WriteLine($"Owner Name       : {vehicle.OwnerName}");
//                Console.WriteLine($"Vehicle Type     : {vehicle.VehicleType}");
//                Console.WriteLine($"Registration No. : {vehicle.RegistrationNumber}");
//                Console.WriteLine($"Registration Fee : {RegistrationFee}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid object. Cannot display registration details.");
//            }
//        }
//    }

//    // Example usage with user input
//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Enter owner name: ");
//            string ownerName = Console.ReadLine();

//            Console.Write("Enter vehicle type (Car/Bike/Truck): ");
//            string vehicleType = Console.ReadLine();

//            Console.Write("Enter registration number: ");
//            string registrationNumber = Console.ReadLine();

//            // Create Vehicle object
//            Vehicle vehicle = new Vehicle(ownerName, vehicleType, registrationNumber);

//            // Display vehicle details
//            vehicle.DisplayRegistrationDetails(vehicle);

//            // Ask user if they want to update the registration fee
//            Console.Write("\nDo you want to update the registration fee? (yes/no): ");
//            string choice = Console.ReadLine().ToLower();

//            if (choice == "yes")
//            {
//                Console.Write("Enter new registration fee: ");
//                if (double.TryParse(Console.ReadLine(), out double newFee))
//                {
//                    Vehicle.UpdateRegistrationFee(newFee);
//                    vehicle.DisplayRegistrationDetails(vehicle);
//                }
//                else
//                {
//                    Console.WriteLine("Invalid fee amount entered.");
//                }
//            }
//        }
//    }

//}
