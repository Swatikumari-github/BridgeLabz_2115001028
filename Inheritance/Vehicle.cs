//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Inheritance
//{
   
//    class Program
//    {
//        static void Main()
//        {
//            Vehicle[] vehicles =
//            {
//            new Car("Verna", 180, "Petrol", 5),
//            new Truck("Tata Motors", 120, "Diesel", 10),
//            new Motorcycle("GT 650", 160, "Petrol", false)
//        };

//            foreach (Vehicle vehicle in vehicles)
//            {
//                vehicle.DisplayInfo();
//                Console.WriteLine();
//            }
//        }
//    }

//    class Vehicle
//    {
//        protected string Name;
//        protected int MaxSpeed;
//        protected string FuelType;

//        public Vehicle(string name, int maxSpeed, string fuelType)
//        {
//            Name = name;
//            MaxSpeed = maxSpeed;
//            FuelType = fuelType;
//        }

//        public virtual void DisplayInfo()
//        {
//            Console.WriteLine($"Name: {Name}, Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
//        }
//    }

//    class Car : Vehicle
//    {
//        private int SeatCapacity;

//        public Car(string name, int maxSpeed, string fuelType, int seatCapacity) : base(name, maxSpeed, fuelType)
//        {
//            SeatCapacity = seatCapacity;
//        }

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//            Console.WriteLine($"Seat Capacity: {SeatCapacity}");
//        }
//    }

//    class Truck : Vehicle
//    {
//        private int LoadCapacity;

//        public Truck(string name, int maxSpeed, string fuelType, int loadCapacity) : base(name, maxSpeed, fuelType)
//        {
//            LoadCapacity = loadCapacity;
//        }

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//            Console.WriteLine($"Load Capacity: {LoadCapacity} tons");
//        }
//    }

//    class Motorcycle : Vehicle
//    {
//        private bool HasSidecar;

//        public Motorcycle(string name, int maxSpeed, string fuelType, bool hasSidecar) : base(name, maxSpeed, fuelType)
//        {
//            HasSidecar = hasSidecar;
//        }

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//            Console.WriteLine($"Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
//        }
//    }


//}
