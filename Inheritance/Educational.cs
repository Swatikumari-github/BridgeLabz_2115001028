//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Inheritance
//{
   

//    class Program
//    {
//        static void Main()
//        {
//            Course basicCourse = new Course("Introduction to Java", 6);
//            OnlineCourse onlineCourse = new OnlineCourse("Web Development", 8, "Udemy", true);
//            PaidOnlineCourse paidCourse = new PaidOnlineCourse("Data Science", 12, "Coursera", true, 299.99, 20);

//            basicCourse.DisplayCourseInfo();
//            Console.WriteLine();
//            onlineCourse.DisplayCourseInfo();
//            Console.WriteLine();
//            paidCourse.DisplayCourseInfo();
//        }
//    }

//    class Course
//    {
//        protected string CourseName;
//        protected int Duration;

//        public Course(string courseName, int duration)
//        {
//            CourseName = courseName;
//            Duration = duration;
//        }

//        public virtual void DisplayCourseInfo()
//        {
//            Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks");
//        }
//    }

//    class OnlineCourse : Course
//    {
//        protected string Platform;
//        protected bool IsRecorded;

//        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
//        {
//            Platform = platform;
//            IsRecorded = isRecorded;
//        }

//        public override void DisplayCourseInfo()
//        {
//            base.DisplayCourseInfo();
//            Console.WriteLine($"Platform: {Platform}, Recorded: {(IsRecorded ? "Yes" : "No")}");
//        }
//    }

//    class PaidOnlineCourse : OnlineCourse
//    {
//        private double Fee;
//        private double Discount;

//        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) : base(courseName, duration, platform, isRecorded)
//        {
//            Fee = fee;
//            Discount = discount;
//        }

//        public override void DisplayCourseInfo()
//        {
//            base.DisplayCourseInfo();
//            Console.WriteLine($"Fee: ${Fee}, Discount: {Discount}%");
//        }
//    }
//}
