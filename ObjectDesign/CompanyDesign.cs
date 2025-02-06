//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObjectDesign
//{
//    using System;
//    using System.Collections.Generic;

//    // Employee class
//    class Employee
//    {
//        public string Name { get; set; }
//        public string Position { get; set; }

//        public Employee(string name, string position)
//        {
//            Name = name;
//            Position = position;
//        }

//        public void DisplayInfo()
//        {
//            Console.WriteLine($"Employee: {Name}, Position: {Position}");
//        }
//    }

//    // Department class (part of the company)
//    class Department
//    {
//        public string Name { get; set; }
//        private List<Employee> Employees { get; set; }

//        public Department(string name)
//        {
//            Name = name;
//            Employees = new List<Employee>();
//        }

//        public void AddEmployee(string name, string position)
//        {
//            Employees.Add(new Employee(name, position));
//        }

//        public void DisplayEmployees()
//        {
//            Console.WriteLine($"Department: {Name}");
//            foreach (var employee in Employees)
//            {
//                employee.DisplayInfo();
//            }
//        }
//    }

//    // Company class (composes Departments)
//    class Company
//    {
//        public string Name { get; set; }
//        private List<Department> Departments { get; set; }

//        public Company(string name)
//        {
//            Name = name;
//            Departments = new List<Department>();
//        }

//        public void AddDepartment(string departmentName)
//        {
//            Departments.Add(new Department(departmentName));
//        }

//        public void AddEmployeeToDepartment(string departmentName, string employeeName, string position)
//        {
//            var department = Departments.Find(d => d.Name == departmentName);
//            if (department != null)
//            {
//                department.AddEmployee(employeeName, position);
//            }
//            else
//            {
//                Console.WriteLine("Department not found!");
//            }
//        }

//        public void DisplayCompany()
//        {
//            Console.WriteLine($"Company: {Name}");
//            foreach (var department in Departments)
//            {
//                department.DisplayEmployees();
//            }
//        }
//    }

//    class CompanyDesign
//    {
//        static void Main()
//        {
//            // Create a company
//            Console.Write("Enter company name: ");
//            string companyName = Console.ReadLine();
//            Company company = new Company(companyName);

//            // Add departments
//            Console.Write("Enter number of departments: ");
//            int deptCount = int.Parse(Console.ReadLine());

//            for (int i = 0; i < deptCount; i++)
//            {
//                Console.Write($"Enter name of department {i + 1}: ");
//                string deptName = Console.ReadLine();
//                company.AddDepartment(deptName);
//            }

//            // Add employees
//            Console.Write("Enter number of employees: ");
//            int empCount = int.Parse(Console.ReadLine());

//            for (int i = 0; i < empCount; i++)
//            {
//                Console.Write("Enter employee name: ");
//                string empName = Console.ReadLine();
//                Console.Write("Enter employee position: ");
//                string empPosition = Console.ReadLine();
//                Console.Write("Enter department name for the employee: ");
//                string deptName = Console.ReadLine();
//                company.AddEmployeeToDepartment(deptName, empName, empPosition);
//            }

//            // Display company structure
//            company.DisplayCompany();
//        }
//    }

//}
