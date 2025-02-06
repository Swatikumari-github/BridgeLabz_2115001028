using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDesign
{
   

    class Course
    {
        public string CourseName { get; set; }
        public Professor AssignedProfessor { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public Course(string courseName)
        {
            CourseName = courseName;
            EnrolledStudents = new List<Student>();
        }

        // Assign professor to the course
        public void AssignProfessor(Professor professor)
        {
            AssignedProfessor = professor;
            Console.WriteLine($"Professor {professor.Name} is now teaching the {CourseName} course.");
        }

        // Enroll student in the course
        public void EnrollStudent(Student student)
        {
            EnrolledStudents.Add(student);
            Console.WriteLine($"{student.Name} has enrolled in the {CourseName} course.");
        }

        // View course details
        public void ViewCourseDetails()
        {
            Console.WriteLine($"Course: {CourseName}");
            Console.WriteLine($"Professor: {AssignedProfessor?.Name ?? "No professor assigned"}");
            Console.WriteLine("Enrolled Students:");
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<Course> CoursesEnrolled { get; set; }

        public Student(string name)
        {
            Name = name;
            CoursesEnrolled = new List<Course>();
        }

        // Enroll in a course
        public void EnrollCourse(Course course)
        {
            course.EnrollStudent(this);
            CoursesEnrolled.Add(course);
        }

        // View student's enrolled courses
        public void ViewEnrolledCourses()
        {
            Console.WriteLine($"{Name} is enrolled in the following courses:");
            foreach (var course in CoursesEnrolled)
            {
                Console.WriteLine($"- {course.CourseName}");
            }
        }
    }

    class Professor
    {
        public string Name { get; set; }
        public List<Course> CoursesTaught { get; set; }

        public Professor(string name)
        {
            Name = name;
            CoursesTaught = new List<Course>();
        }

        // Assign a professor to a course (already done in Course class)
        public void AssignToCourse(Course course)
        {
            course.AssignProfessor(this);
            CoursesTaught.Add(course);
        }

        // View courses taught by the professor
        public void ViewCoursesTaught()
        {
            Console.WriteLine($"{Name} teaches the following courses:");
            foreach (var course in CoursesTaught)
            {
                Console.WriteLine($"- {course.CourseName}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Create professors
            Console.Write("Enter the name of the first professor: ");
            string professor1Name = Console.ReadLine();
            Console.Write("Enter the name of the second professor: ");
            string professor2Name = Console.ReadLine();
            Professor professor1 = new Professor(professor1Name);
            Professor professor2 = new Professor(professor2Name);

            // Create courses
            Console.Write("Enter the name of the first course: ");
            string course1Name = Console.ReadLine();
            Console.Write("Enter the name of the second course: ");
            string course2Name = Console.ReadLine();
            Course course1 = new Course(course1Name);
            Course course2 = new Course(course2Name);

            // Assign professors to courses
            professor1.AssignToCourse(course1);
            professor2.AssignToCourse(course2);

            // Create students
            Console.Write("Enter the name of the first student: ");
            string student1Name = Console.ReadLine();
            Console.Write("Enter the name of the second student: ");
            string student2Name = Console.ReadLine();
            Student student1 = new Student(student1Name);
            Student student2 = new Student(student2Name);

            // Enroll students in courses
            Console.WriteLine("\nEnrolling students in courses...");
            student1.EnrollCourse(course1);
            student1.EnrollCourse(course2);
            student2.EnrollCourse(course2);

            // View course details
            Console.WriteLine("\nCourse Details:");
            course1.ViewCourseDetails();
            course2.ViewCourseDetails();

            // View student enrollments
            Console.WriteLine("\nStudent Enrollments:");
            student1.ViewEnrolledCourses();
            student2.ViewEnrolledCourses();

            // View professor's courses
            Console.WriteLine("\nProfessor's Courses:");
            professor1.ViewCoursesTaught();
            professor2.ViewCoursesTaught();
        }
    }

}
