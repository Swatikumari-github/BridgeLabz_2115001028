//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{
//    class Course
//    {
//        // Class variable (common for all courses)
//        public static string instituteName = "GLA Institute";

//        // Instance variables
//        public string courseName;
//        public int duration; // in months
//        public double fee;

//        // Constructor to initialize instance variables
//        public Course(string courseName, int duration, double fee)
//        {
//            this.courseName = courseName;
//            this.duration = duration;
//            this.fee = fee;
//        }

//        // Method to display course information
//        public void DisplayCourseInfo()
//        {
//            Console.WriteLine($"Institute: {Course.instituteName}");
//            Console.WriteLine($"Course Name: {courseName}");
//            Console.WriteLine($"Duration: {duration} months");
//            Console.WriteLine($"Fee: ${fee}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating instances of Course class
//            Course course1 = new Course("Python Programming", 4, 800);
//            Course course2 = new Course("Data Science", 8, 900);

//            // Displaying course information
//            course1.DisplayCourseInfo();
//            Console.WriteLine();  // Adding a line break between courses
//            course2.DisplayCourseInfo();
//        }
//    }
//}
