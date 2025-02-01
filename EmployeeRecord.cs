using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignmemt
{
    using System;

    class Employee
    {
        // Public field (accessible from anywhere)
        public int employeeID;

        // Protected field (accessible within this class and derived classes)
        protected string department;

        // Private field (accessible only within this class)
        private double salary;

        // Constructor to initialize employee details
        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        // Public method to get the salary
        public double GetSalary()
        {
            return salary;
        }

        // Public method to modify the salary
        public void SetSalary(double newSalary)
        {
            salary = newSalary;
        }

        // Method to display employee details (for testing purposes)
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {employeeID}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Salary: ${salary}");
        }
    }

    // Subclass to demonstrate the use of access modifiers
    class Manager : Employee
    {
        // Constructor to initialize manager details
        public Manager(int employeeID, string department, double salary)
            : base(employeeID, department, salary)  // Calling base class constructor
        {
        }

        // Method to display manager details (accessing public and protected members)
        public void DisplayManagerDetails()
        {
            Console.WriteLine($"Manager - Employee ID: {employeeID}");  // Accessing public field employeeID
            Console.WriteLine($"Department: {department}");  // Accessing protected field department
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an instance of Employee class
            Employee employee1 = new Employee(1001, "Sales", 55000);

            // Displaying employee details
            Console.WriteLine("Employee Details:");
            employee1.DisplayEmployeeDetails();

            // Using public methods to modify the salary
            Console.WriteLine("\nModifying and accessing salary:");
            Console.WriteLine($"Current Salary: ${employee1.GetSalary()}");
            employee1.SetSalary(60000);  // Modifying salary
            Console.WriteLine($"Updated Salary: ${employee1.GetSalary()}");

            // Creating an instance of Manager class
            Manager manager1 = new Manager(2001, "Management", 85000);

            // Displaying manager details (accessing employeeID and department)
            Console.WriteLine("\nManager Details:");
            manager1.DisplayManagerDetails();
        }
    }

}
