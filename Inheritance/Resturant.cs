using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    using System;

    class Program
    {
        static void Main()
        {
            Chef chef = new Chef("Gordon Ramsay", 101, "Italian Cuisine");
            Waiter waiter = new Waiter("Ramu", 202, 5);

            chef.DisplayInfo();
            chef.PerformDuties();
            Console.WriteLine();

            waiter.DisplayInfo();
            waiter.PerformDuties();
        }
    }

    class Person
    {
        protected string Name;
        protected int Id;

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }
    }

    interface IWorker
    {
        void PerformDuties();
    }

    class Chef : Person, IWorker
    {
        private string Specialty;

        public Chef(string name, int id, string specialty) : base(name, id)
        {
            Specialty = specialty;
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is preparing delicious {Specialty}.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Chef, Specialty: {Specialty}");
        }
    }

    class Waiter : Person, IWorker
    {
        private int TablesAssigned;

        public Waiter(string name, int id, int tablesAssigned) : base(name, id)
        {
            TablesAssigned = tablesAssigned;
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is serving customers at {TablesAssigned} tables.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Waiter, Tables Assigned: {TablesAssigned}");
        }
    }


}