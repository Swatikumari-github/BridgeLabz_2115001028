using System;
using System.Reflection;
namespace AnnotationReflection
{
   

    // Define the repeatable BugReport attribute
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class BugReportAttribute : Attribute
    {
        public string Description { get; }

        public BugReportAttribute(string description)
        {
            Description = description;
        }
    }

    // Class with methods marked by multiple BugReport attributes
    class TaskManager
    {
        [BugReport("Fix the null reference issue.")]
        [BugReport("Optimize the performance of the method.")]
        public void ProcessTask()
        {
            Console.WriteLine("Processing task...");
        }
    }

    class BugReport
    {
        static void Main()
        {
            TaskManager taskManager = new TaskManager(); // Changed variable name to taskManager

            // Get the method info for ProcessTask in TaskManager class
            MethodInfo taskMethod = typeof(TaskManager).GetMethod("ProcessTask"); // Changed variable name to taskMethod

            // Retrieve all BugReport attributes applied to the method
            var bugReportsList = (BugReportAttribute[])taskMethod.GetCustomAttributes(typeof(BugReportAttribute), false); // Changed variable name to bugReportsList

            // Print all bug reports
            foreach (var bugReport in bugReportsList)
            {
                Console.WriteLine($"Bug Report: {bugReport.Description}");
            }
        }
    }

}
