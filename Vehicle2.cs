//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{
   

//    class Vehicle2
//    {
//        // Class variable (fixed registration fee for all vehicles)
//        public static double registrationFee = 100.0;

//        // Instance variables
//        public string ownerName;
//        public string vehicleType;

//        // Constructor to initialize instance variables
//        public Vehicle2(string ownerName, string vehicleType)
//        {
//            this.ownerName = ownerName;
//            this.vehicleType = vehicleType;
//        }

//        // Instance method to display vehicle details
//        public void DisplayVehicleDetails()
//        {
//            Console.WriteLine($"Owner: {ownerName}");
//            Console.WriteLine($"Vehicle Type: {vehicleType}");
//            Console.WriteLine($"Registration Fee: ${Vehicle2.registrationFee}");
//        }

//        // Class method to update the registration fee for all vehicles
//        public static void UpdateRegistrationFee(double newFee)
//        {
//            Vehicle2.registrationFee = newFee;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating instances of Vehicle class
//            Vehicle2 vehicle1 = new Vehicle2("Swati", "Car");
//            Vehicle2 vehi2 = new Vehicle2("SumitPathak", "Motorcycle");

//            // Displaying vehicle information before updating the registration fee
//            Console.WriteLine("Before updating registration fee:");
//            vehicle1.DisplayVehicleDetails();
//            Console.WriteLine();  // Adding a line break between vehicles
//            vehi2.DisplayVehicleDetails();

//            // Updating the registration fee for all vehicles
//            Vehicle2.UpdateRegistrationFee(120.0);

//            // Displaying vehicle information after updating the registration fee
//            Console.WriteLine("\nAfter updating registration fee:");
//            vehicle1.DisplayVehicleDetails();
//            Console.WriteLine();  // Adding a line break between vehicles
//            vehi2.DisplayVehicleDetails();
//        }
//    }

//}
