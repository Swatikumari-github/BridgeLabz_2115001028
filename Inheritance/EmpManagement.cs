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
//            Employee manager = new Manager("Raj", 101, 80000, 10);
//            Employee developer = new Developer("Swati", 102, 60000, "Java");
//            Employee intern = new Intern("Shashank", 103, 20000, 6);

//            manager.DisplayDetails();
//            Console.WriteLine();
//            developer.DisplayDetails();
//            Console.WriteLine();
//            intern.DisplayDetails();
//        }
//    }

//    class Employee
//    {
//        protected string Name;
//        protected int Id;
//        protected double Salary;

//        public Employee(string name, int id, double salary)
//        {
//            Name = name;
//            Id = id;
//            Salary = salary;
//        }

//        public virtual void DisplayDetails()
//        {
//            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
//        }
//    }

//    class Manager : Employee
//    {
//        private int TeamSize;

//        public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
//        {
//            TeamSize = teamSize;
//        }

//        public override void DisplayDetails()
//        {
//            base.DisplayDetails();
//            Console.WriteLine($"Team Size: {TeamSize}");
//        }
//    }

//    class Developer : Employee
//    {
//        private string ProgrammingLanguage;

//        public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
//        {
//            ProgrammingLanguage = programmingLanguage;
//        }

//        public override void DisplayDetails()
//        {
//            base.DisplayDetails();
//            Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
//        }
//    }

//    class Intern : Employee
//    {
//        private int Duration;

//        public Intern(string name, int id, double salary, int duration) : base(name, id, salary)
//        {
//            Duration = duration;
//        }

//        public override void DisplayDetails()
//        {
//            base.DisplayDetails();
//            Console.WriteLine($"Internship Duration: {Duration} months");
//        }
//    }



//}
