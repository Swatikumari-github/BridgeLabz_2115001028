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
//        public static string instituteName = "ABC Institute";

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

//        // Instance method to display course details
//        public void DisplayCourseDetails()
//        {
//            Console.WriteLine($"Institute: {Course.instituteName}");
//            Console.WriteLine($"Course Name: {courseName}");
//            Console.WriteLine($"Duration: {duration} months");
//            Console.WriteLine($"Fee: ${fee}");
//        }

//        // Class method to modify the institute name for all courses
//        public static void UpdateInstituteName(string newInstituteName)
//        {
//            Course.instituteName = newInstituteName;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating instances of Course class
//            Course course1 = new Course("Python Programming", 6, 300);
//            Course course2 = new Course("Data Science", 12, 500);

//            // Displaying course information
//            Console.WriteLine("Before updating institute name:");
//            course1.DisplayCourseDetails();
//            Console.WriteLine();  // Adding a line break between courses
//            course2.DisplayCourseDetails();

//            // Updating the institute name for all courses
//            Course.UpdateInstituteName("XYZ Institute");

//            // Displaying course information after institute name update
//            Console.WriteLine("\nAfter updating institute name:");
//            course1.DisplayCourseDetails();
//            Console.WriteLine();  // Adding a line break between courses
//            course2.DisplayCourseDetails();
//        }
//    }
//}
