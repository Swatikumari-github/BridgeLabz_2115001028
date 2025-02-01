//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{
//    using System;

//    class Student1
//    {
//        // Public field, accessible from anywhere
//        public int rollNumber;

//        // Protected field, accessible within this class and derived classes
//        protected string name;

//        // Private field, accessible only within this class
//        private double CGPA;

//        // Constructor to initialize the student details
//        public Student1(int rollNumber, string name, double CGPA)
//        {
//            this.rollNumber = rollNumber;
//            this.name = name;
//            this.CGPA = CGPA;
//        }

//        // Public method to display student details (showing private data through a method)
//        public void DisplayStudentDetails()
//        {
//            Console.WriteLine($"Roll Number: {rollNumber}");
//            Console.WriteLine($"Name: {name}");
//            Console.WriteLine($"CGPA: {CGPA}");
//        }

//        // Public method to modify the CGPA (since it is private)
//        public void UpdateCGPA(double newCGPA)
//        {
//            CGPA = newCGPA;
//        }

//        // Protected method to access or modify name (if needed in derived classes)
//        protected void SetName(string newName)
//        {
//            name = newName;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating an instance of Student class
//            Student1 student1 = new Student1(10, "Swati", 3.75);

//            // Accessing the public field directly
//            Console.WriteLine("Accessing public field (rollNumber): " + student1.rollNumber);

//            // Accessing the public method to display student details
//            student1.DisplayStudentDetails();

//            // Updating CGPA using the public method
//            student1.UpdateCGPA(3.85);

//            // Displaying updated student details
//            Console.WriteLine("\nUpdated Student Details:");
//            student1.DisplayStudentDetails();
//        }
//    }

//}
