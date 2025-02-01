//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{
//    class Vehicle
//    {
//        // Class variable (fixed registration fee for all vehicles)
//        public static double registrationFee = 100.0;

//        // Instance variables
//        public string ownerName;
//        public string vehicleType;

//        // Constructor to initialize instance variables
//        public Vehicle(string ownerName, string vehicleType)
//        {
//            this.ownerName = ownerName;
//            this.vehicleType = vehicleType;
//        }

//        // Instance method to display vehicle details
//        public void DisplayVehicleDetails()
//        {
//            Console.WriteLine($"Owner: {ownerName}");
//            Console.WriteLine($"Vehicle Type: {vehicleType}");
//            Console.WriteLine($"Registration Fee: ${Vehicle.registrationFee}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating instances of Vehicle class
//            Vehicle vehicle1 = new Vehicle("SwatiPathak", "Car");
//            Vehicle vehicle2 = new Vehicle("SumitPathak", "Motorcycle");

//            // Displaying vehicle information
//            Console.WriteLine("Vehicle 1 Details:");
//            vehicle1.DisplayVehicleDetails();
//            Console.WriteLine();  // Adding a line break between vehicles

//            Console.WriteLine("Vehicle 2 Details:");
//            vehicle2.DisplayVehicleDetails();
//        }
//    }
//}
