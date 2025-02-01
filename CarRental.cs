//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{
//    class CarRental
//    {
//        private string customerName;
//        private string carModel;
//        private int rentalDays;
//        private double dailyRate;

//        // Default Constructor
//        public CarRental() : this("Unknown", "Standard", 1, 55.0) { }

//        // Parameterized Constructor
//        public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
//        {
//            this.customerName = customerName;
//            this.carModel = carModel;
//            this.rentalDays = rentalDays;
//            this.dailyRate = dailyRate;
//        }

//        // Method to Calculate Total Cost
//        public double CalculateTotalCost()
//        {
//            return rentalDays * dailyRate;
//        }

//        public void Display()
//        {
//            Console.WriteLine($"Customer: {customerName}, Car Model: {carModel}, Rental Days: {rentalDays}, Total Cost: ${CalculateTotalCost():F2}");
//        }
//    }

//    // Example Usage
//    class Program
//    {
//        static void Main()
//        {
//            CarRental rental1 = new CarRental("Swati Pathak", "SUV", 5, 75.0);
//            rental1.Display();
//        }
//    }

//}
