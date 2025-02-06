//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObjectDesign
//{
//    using System;
//    using System.Collections.Generic;

//    class Student
//    {
//        public string Name { get; set; }
//        public List<Course> Courses { get; set; }

//        public Student(string name)
//        {
//            Name = name;
//            Courses = new List<Course>();
//        }

//        // Method to enroll in a course
//        public void Enroll(Course course)
//        {
//            if (!Courses.Contains(course))
//            {
//                Courses.Add(course);
//                course.AddStudent(this); // Enroll the student in the course
//            }
//        }

//        // Method to view enrolled courses
//        public void ViewCourses()
//        {
//            Console.WriteLine($"{Name} is enrolled in the following courses:");
//            foreach (var course in Courses)
//            {
//                Console.WriteLine(course.Name);
//            }
//        }
//    }

//    class Course
//    {
//        public string Name { get; set; }
//        public List<Student> Students { get; set; }

//        public Course(string name)
//        {
//            Name = name;
//            Students = new List<Student>();
//        }

//        // Method to add a student to the course
//        public void AddStudent(Student student)
//        {
//            if (!Students.Contains(student))
//            {
//                Students.Add(student);
//            }
//        }

//        // Method to view students enrolled in the course
//        public void ViewStudents()
//        {
//            Console.WriteLine($"Students enrolled in {Name}:");
//            foreach (var student in Students)
//            {
//                Console.WriteLine(student.Name);
//            }
//        }
//    }

//    class School
//    {
//        public string Name { get; set; }
//        public List<Student> Students { get; set; }
//        public List<Course> Courses { get; set; }

//        public School(string name)
//        {
//            Name = name;
//            Students = new List<Student>();
//            Courses = new List<Course>();
//        }

//        // Method to add a student to the school
//        public void AddStudent(Student student)
//        {
//            if (!Students.Contains(student))
//            {
//                Students.Add(student);
//            }
//        }

//        // Method to add a course to the school
//        public void AddCourse(Course course)
//        {
//            if (!Courses.Contains(course))
//            {
//                Courses.Add(course);
//            }
//        }

//        // Method to view students in the school
//        public void ViewStudents()
//        {
//            Console.WriteLine($"Students in {Name}:");
//            foreach (var student in Students)
//            {
//                Console.WriteLine(student.Name);
//            }
//        }
//    }

//    class SchoolManagement
//    {
//        static void Main()
//        {
//            // Create a school
//            Console.Write("Enter the name of the school: ");
//            string schoolName = Console.ReadLine();
//            School school = new School(schoolName);

//            // Add students
//            Console.Write("Enter the number of students: ");
//            int numStudents = int.Parse(Console.ReadLine());
//            for (int i = 0; i < numStudents; i++)
//            {
//                Console.Write($"Enter name of student {i + 1}: ");
//                string studentName = Console.ReadLine();
//                Student student = new Student(studentName);
//                school.AddStudent(student);
//            }

//            // Add courses
//            Console.Write("Enter the number of courses: ");
//            int numCourses = int.Parse(Console.ReadLine());
//            for (int i = 0; i < numCourses; i++)
//            {
//                Console.Write($"Enter name of course {i + 1}: ");
//                string courseName = Console.ReadLine();
//                Course course = new Course(courseName);
//                school.AddCourse(course);
//            }

//            // Enroll students in courses
//            foreach (var student in school.Students)
//            {
//                Console.WriteLine($"\nEnrolling student {student.Name}...");
//                Console.Write("Enter the number of courses this student should enroll in: ");
//                int enrollCount = int.Parse(Console.ReadLine());

//                for (int i = 0; i < enrollCount; i++)
//                {
//                    Console.Write("Enter the name of the course to enroll in: ");
//                    string courseName = Console.ReadLine();
//                    Course course = school.Courses.Find(c => c.Name == courseName);

//                    if (course != null)
//                    {
//                        student.Enroll(course);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Course not found!");
//                    }
//                }
//            }

//            // View student's enrolled courses
//            Console.WriteLine("\nStudent Enrollments:");
//            foreach (var student in school.Students)
//            {
//                student.ViewCourses();
//            }

//            // View courses and their enrolled students
//            Console.WriteLine("\nCourses and Enrolled Students:");
//            foreach (var course in school.Courses)
//            {
//                course.ViewStudents();
//            }
//        }
//    }

//}
