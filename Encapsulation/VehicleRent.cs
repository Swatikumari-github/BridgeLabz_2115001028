//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Intrinsics.X86;
//using System.Text;
//using System.Threading.Tasks;

//namespace Encapsulation
//{
    
//    // Abstract class Vehicle
//    abstract class Vehicle
//    {
//        public string VehicleNumber { get; set; }
//        public string Type { get; set; }
//        public double RentalRate { get; set; }

//        protected Vehicle(string vehicleNumber, string type, double rentalRate)
//        {
//            VehicleNumber = vehicleNumber;
//            Type = type;
//            RentalRate = rentalRate;
//        }

//        public abstract double CalculateRentalCost(int days);
//    }

//    // Interface IInsurable
//    interface IInsurable
//    {
//        double CalculateInsurance();
//        string GetInsuranceDetails();
//    }

//    // Car class
//    class Car : Vehicle, IInsurable
//    {
//        private string insurancePolicyNumber;

//        public Car(string vehicleNumber, double rentalRate, string insurancePolicy)
//            : base(vehicleNumber, "Car", rentalRate)
//        {
//            insurancePolicyNumber = insurancePolicy;
//        }

//        public override double CalculateRentalCost(int days)
//        {
//            return days * RentalRate;
//        }

//        public double CalculateInsurance()
//        {
//            return RentalRate * 0.1; // Example insurance calculation
//        }

//        public string GetInsuranceDetails()
//        {
//            return "Insurance Policy: " + new string('*', insurancePolicyNumber.Length - 3) + insurancePolicyNumber[^3..];
//        }
//    }

//    // Bike class
//    class Bike : Vehicle, IInsurable
//    {
//        private string insurancePolicyNumber;

//        public Bike(string vehicleNumber, double rentalRate, string insurancePolicy)
//            : base(vehicleNumber, "Bike", rentalRate)
//        {
//            insurancePolicyNumber = insurancePolicy;
//        }

//        public override double CalculateRentalCost(int days)
//        {
//            return days * RentalRate;
//        }

//        public double CalculateInsurance()
//        {
//            return RentalRate * 0.05; // Example insurance calculation
//        }

//        public string GetInsuranceDetails()
//        {
//            return "Insurance Policy: " + new string('*', insurancePolicyNumber.Length - 3) + insurancePolicyNumber[^3..];
//        }
//    }

//    // Truck class
//    class Truck : Vehicle, IInsurable
//    {
//        private string insurancePolicyNumber;

//        public Truck(string vehicleNumber, double rentalRate, string insurancePolicy)
//            : base(vehicleNumber, "Truck", rentalRate)
//        {
//            insurancePolicyNumber = insurancePolicy;
//        }

//        public override double CalculateRentalCost(int days)
//        {
//            return days * RentalRate * 1.2; // Trucks have higher rental rates
//        }

//        public double CalculateInsurance()
//        {
//            return RentalRate * 0.15; // Example insurance calculation
//        }

//        public string GetInsuranceDetails()
//        {
//            return "Insurance Policy: " + new string('*', insurancePolicyNumber.Length - 3) + insurancePolicyNumber[^3..];
//        }
//    }

//    // Main program
//    class VehicleRent

//    {
//        static void Main()
//        {
//            List<Vehicle> vehicles = new List<Vehicle>();
//            vehicles.Add(new Car("C123", 50, "CAR12345"));
//            vehicles.Add(new Bike("B456", 20, "BIKE6789"));
//            vehicles.Add(new Truck("T789", 100, "TRUCK54321"));

//            Console.Write("Enter number of rental days: ");
//            int days = int.Parse(Console.ReadLine());

//            foreach (var vehicle in vehicles)
//            {
//                IInsurable insurableVehicle = vehicle as IInsurable;
//                Console.WriteLine($"\nVehicle: {vehicle.Type} ({vehicle.VehicleNumber})");
//                Console.WriteLine($"Rental Cost for {days} days: ${vehicle.CalculateRentalCost(days)}");
//                Console.WriteLine($"Insurance Cost: ${insurableVehicle.CalculateInsurance()}");
//                Console.WriteLine(insurableVehicle.GetInsuranceDetails());
//            }
//        }
//    }


//}
