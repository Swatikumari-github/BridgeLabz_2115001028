using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
  

    class VehicleManagement
    {
        static void Main(string[] args)
        {
            ElectricVehicle ev = new ElectricVehicle("Tesla Model S", 250, 100);
            PetrolVehicle pv = new PetrolVehicle("Toyota Corolla", 180, 50);

            ev.DisplayInfo();
            ev.Charge();
            Console.WriteLine();

            pv.DisplayInfo();
            pv.Refuel();
        }
    }

    class Vehicle
    {
        protected string Model;
        protected int MaxSpeed;

        public Vehicle(string model, int maxSpeed)
        {
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}, Max Speed: {MaxSpeed} km/h");
        }
    }

    interface IRefuelable
    {
        void Refuel();
    }

    class ElectricVehicle : Vehicle
    {
        private int BatteryCapacity;

        public ElectricVehicle(string model, int maxSpeed, int batteryCapacity)
            : base(model, maxSpeed)
        {
            BatteryCapacity = batteryCapacity;
        }

        public void Charge()
        {
            Console.WriteLine($"{Model} is charging. Battery capacity: {BatteryCapacity} kWh.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Electric Vehicle, Battery Capacity: {BatteryCapacity} kWh");
        }
    }

    class PetrolVehicle : Vehicle, IRefuelable
    {
        private int FuelCapacity;

        public PetrolVehicle(string model, int maxSpeed, int fuelCapacity)
            : base(model, maxSpeed)
        {
            FuelCapacity = fuelCapacity;
        }

        public void Refuel()
        {
            Console.WriteLine($"{Model} is refueling. Fuel capacity: {FuelCapacity} liters.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Petrol Vehicle, Fuel Capacity: {FuelCapacity} liters");
        }
    }

}
