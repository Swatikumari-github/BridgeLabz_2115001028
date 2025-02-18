using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    

    // Abstract base class for different course types
    public abstract class CourseCategory
    {
        public string Title { get; set; }
        public string Faculty { get; set; }

        public CourseCategory(string title, string faculty)
        {
            Title = title;
            Faculty = faculty;
        }

        public abstract void ShowDetails();
    }

    // Exam-Based Course Category
    public class ExamBasedCourse : CourseCategory
    {
        public int MaxMarks { get; set; }

        public ExamBasedCourse(string title, string faculty, int maxMarks)
            : base(title, faculty)
        {
            MaxMarks = maxMarks;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"[Exam Course] {Title} - {Faculty}, Max Marks: {MaxMarks}");
        }
    }

    // Assignment-Based Course Category
    public class AssignmentBasedCourse : CourseCategory
    {
        public int TotalTasks { get; set; }

        public AssignmentBasedCourse(string title, string faculty, int totalTasks)
            : base(title, faculty)
        {
            TotalTasks = totalTasks;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"[Assignment Course] {Title} - {Faculty}, Total Tasks: {TotalTasks}");
        }
    }

    // Generic Course Manager with constraint on CourseCategory
    public class CourseManager<T> where T : CourseCategory
    {
        private List<T> courseList = new List<T>();

        public void RegisterCourse(T course)
        {
            courseList.Add(course);
        }

        public void DisplayCourses()
        {
            foreach (var course in courseList)
            {
                course.ShowDetails();
            }
        }
    }

    // Main Program
    class CourseManagement
    {
        static void Main()
        {
            // Create course managers for different course categories
            CourseManager<ExamBasedCourse> examCourseManager = new CourseManager<ExamBasedCourse>();
            CourseManager<AssignmentBasedCourse> assignmentCourseManager = new CourseManager<AssignmentBasedCourse>();

            // Add courses
            examCourseManager.RegisterCourse(new ExamBasedCourse("Algebra", "Mathematics", 100));
            examCourseManager.RegisterCourse(new ExamBasedCourse("Mechanics", "Physics", 80));

            assignmentCourseManager.RegisterCourse(new AssignmentBasedCourse("Creative Writing", "English", 6));
            assignmentCourseManager.RegisterCourse(new AssignmentBasedCourse("World History", "History", 4));

            // Display courses
            Console.WriteLine("\n--- Exam-Based Courses ---");
            examCourseManager.DisplayCourses();

            Console.WriteLine("\n--- Assignment-Based Courses ---");
            assignmentCourseManager.DisplayCourses();
        }
    }


}
