//namespace Oops2
//{
//    using System;

//    class Student
//    {
//        // Static variable shared across all students
//        public static string UniversityName = "GLA University";

//        // Static variable to keep track of the total number of students
//        private static int totalStudents = 0;

//        // Readonly variable for RollNumber
//        public readonly int RollNumber;

//        // Instance variables
//        public string Name { get; set; }
//        public double Grade { get; set; }

//        // Constructor using 'this' to initialize properties
//        public Student(string name, int rollNumber, double grade)
//        {
//            this.Name = name;
//            this.RollNumber = rollNumber;
//            this.Grade = grade;
//            totalStudents++; // Increment total student count
//        }

//        // Static method to display total students
//        public static void DisplayTotalStudents()
//        {
//            Console.WriteLine($"Total students enrolled: {totalStudents}");
//        }

//        // Method to update grade with 'is' operator for type checking
//        public void UpdateGrade(object obj, double newGrade)
//        {
//            if (obj is Student student)
//            {
//                student.Grade = newGrade;
//                Console.WriteLine($"Grade updated for {student.Name} (Roll No: {student.RollNumber}) to {newGrade}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid object. Cannot update grade.");
//            }
//        }

//        // Method to display student details
//        public void DisplayDetails()
//        {
//            Console.WriteLine($"Name: {Name}, Roll Number: {RollNumber}, Grade: {Grade}, University: {UniversityName}");
//        }
//    }

//    // Example usage
//    class Program
//    {
//        static void Main()
//        {
//            Student s1 = new Student("Rohan", 101, 3.8);
//            Student s2 = new Student("Mohan", 102, 3.5);

//            s1.DisplayDetails();
//            s2.DisplayDetails();

//            Student.DisplayTotalStudents();

//            // Updating grade using 'is' operator check
//            s1.UpdateGrade(s1, 3.9);

//            s1.DisplayDetails();
//        }
//    }
//}
