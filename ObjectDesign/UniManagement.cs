//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//namespace ObjectDesign
//{
//    using System;
//    using System.Collections.Generic;

//    class Faculty
//    {
//        public string Name { get; set; }

//        public Faculty(string name)
//        {
//            Name = name;
//        }

//        // Method to view the faculty member's name
//        public void ViewFaculty()
//        {
//            Console.WriteLine($"Faculty: {Name}");
//        }
//    }

//    class Department
//    {
//        public string Name { get; set; }
//        public List<Faculty> FacultyMembers { get; set; }

//        public Department(string name)
//        {
//            Name = name;
//            FacultyMembers = new List<Faculty>();
//        }

//        // Add faculty member to the department
//        public void AddFaculty(Faculty faculty)
//        {
//            FacultyMembers.Add(faculty);
//        }

//        // View the department and its faculty members
//        public void ViewDepartment()
//        {
//            Console.WriteLine($"Department: {Name}");
//            Console.WriteLine("Faculty members:");
//            foreach (var faculty in FacultyMembers)
//            {
//                faculty.ViewFaculty();
//            }
//        }
//    }

//    class University
//    {
//        public string Name { get; set; }
//        public List<Department> Departments { get; set; }

//        public University(string name)
//        {
//            Name = name;
//            Departments = new List<Department>();
//        }

//        // Method to add a department to the university
//        public void AddDepartment(Department department)
//        {
//            Departments.Add(department);
//        }

//        // Method to delete the university, which also deletes its departments
//        public void DeleteUniversity()
//        {
//            Departments.Clear();  // Composition: Deleting university deletes all departments
//            Console.WriteLine($"University {Name} and all its departments have been deleted.");
//        }

//        // View the university and its departments
//        public void ViewUniversity()
//        {
//            Console.WriteLine($"University: {Name}");
//            Console.WriteLine("Departments:");
//            foreach (var department in Departments)
//            {
//                department.ViewDepartment();
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Create a university
//            Console.Write("Enter the name of the university: ");
//            string universityName = Console.ReadLine();
//            University university = new University(universityName);

//            // Create departments
//            Console.Write("Enter the number of departments: ");
//            int numDepartments = int.Parse(Console.ReadLine());
//            for (int i = 0; i < numDepartments; i++)
//            {
//                Console.Write($"Enter name of department {i + 1}: ");
//                string departmentName = Console.ReadLine();
//                Department department = new Department(departmentName);

//                // Create faculty members for each department
//                Console.Write("Enter the number of faculty members in this department: ");
//                int numFaculty = int.Parse(Console.ReadLine());
//                for (int j = 0; j < numFaculty; j++)
//                {
//                    Console.Write($"Enter name of faculty member {j + 1}: ");
//                    string facultyName = Console.ReadLine();
//                    Faculty faculty = new Faculty(facultyName);
//                    department.AddFaculty(faculty);
//                }

//                university.AddDepartment(department);
//            }

//            // View the university and its departments
//            university.ViewUniversity();

//            // Delete the university and show that departments are deleted
//            Console.WriteLine("\nDeleting the university...");
//            university.DeleteUniversity();
//            university.ViewUniversity();

//            // Demonstrate faculty members existing independently
//            Console.WriteLine("\nCreating and viewing a faculty member independently of any department:");
//            Faculty independentFaculty = new Faculty("Dr. John Doe");
//            independentFaculty.ViewFaculty();
//        }
//    }


//}
