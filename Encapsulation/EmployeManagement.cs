//using System;
//using System.Collections.Generic;
//namespace Encapsulation
//{
    

//    // Abstract class Employee
//    abstract class Employee
//    {
//        private int employeeId;
//        private string name;
//        private double baseSalary;

//        public int EmployeeId { get => employeeId; set => employeeId = value; }
//        public string Name { get => name; set => name = value; }
//        public double BaseSalary { get => baseSalary; set => baseSalary = value; }

//        protected Employee(int id, string name, double baseSalary)
//        {
//            EmployeeId = id;
//            Name = name;
//            BaseSalary = baseSalary;
//        }

//        public abstract double CalculateSalary();

//        public void DisplayDetails()
//        {
//            Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary():C}");
//        }
//    }

//    interface IDepartment
//    {
//        void AssignDepartment(string department);
//        string GetDepartmentDetails();
//    }

//    class FullTimeEmployee : Employee, IDepartment
//    {
//        private string department;

//        public FullTimeEmployee(int id, string name, double salary)
//            : base(id, name, salary) { }

//        public override double CalculateSalary()
//        {
//            return BaseSalary;
//        }

//        public void AssignDepartment(string department)
//        {
//            this.department = department;
//        }

//        public string GetDepartmentDetails()
//        {
//            return $"Department: {department}";
//        }
//    }

//    class PartTimeEmployee : Employee, IDepartment
//    {
//        private double hourlyRate;
//        private int hoursWorked;
//        private string department;

//        public PartTimeEmployee(int id, string name, double hourlyRate, int hoursWorked)
//            : base(id, name, 0)
//        {
//            this.hourlyRate = hourlyRate;
//            this.hoursWorked = hoursWorked;
//        }

//        public override double CalculateSalary()
//        {
//            return hourlyRate * hoursWorked;
//        }

//        public void AssignDepartment(string department)
//        {
//            this.department = department;
//        }

//        public string GetDepartmentDetails()
//        {
//            return $"Department: {department}";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            List<Employee> employees = new List<Employee>();

//            Console.Write("Enter the number of employees: ");
//            int numEmployees = int.Parse(Console.ReadLine());

//            for (int i = 0; i < numEmployees; i++)
//            {
//                Console.Write("Enter Employee Type (FullTime/PartTime): ");
//                string type = Console.ReadLine();

//                Console.Write("Enter Employee ID: ");
//                int id = int.Parse(Console.ReadLine());

//                Console.Write("Enter Employee Name: ");
//                string name = Console.ReadLine();

//                if (type.ToLower() == "fulltime")
//                {
//                    Console.Write("Enter Fixed Salary: ");
//                    double salary = double.Parse(Console.ReadLine());
//                    employees.Add(new FullTimeEmployee(id, name, salary));
//                }
//                else if (type.ToLower() == "parttime")
//                {
//                    Console.Write("Enter Hourly Rate: ");
//                    double hourlyRate = double.Parse(Console.ReadLine());

//                    Console.Write("Enter Hours Worked: ");
//                    int hoursWorked = int.Parse(Console.ReadLine());

//                    employees.Add(new PartTimeEmployee(id, name, hourlyRate, hoursWorked));
//                }
//                else
//                {
//                    Console.WriteLine("Invalid employee type!");
//                }
//            }

//            Console.WriteLine("\nEmployee Details:");
//            foreach (Employee emp in employees)
//            {
//                emp.DisplayDetails();
//            }
//        }
//    }


//}