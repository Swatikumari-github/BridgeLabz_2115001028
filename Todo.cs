
using System;
using System.Reflection;
namespace AnnotationReflection
{
  

    // Define the custom Todo attribute
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TodoAttribute : Attribute
    {
        public string Task { get; }
        public string AssignedTo { get; }
        public string Priority { get; }

        // Constructor with optional Priority parameter
        public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }

    // Class with methods marked by the Todo attribute
    class ProjectManager
    {
        [Todo("Implement user authentication", "John Doe", "HIGH")]
        public void Feature1()
        {
            Console.WriteLine("Feature 1 is being developed...");
        }

        [Todo("Add payment gateway integration", "Jane Smith")]
        public void Feature2()
        {
            Console.WriteLine("Feature 2 is being developed...");
        }

        [Todo("Create admin dashboard", "Tom Lee", "LOW")]
        public void Feature3()
        {
            Console.WriteLine("Feature 3 is being developed...");
        }
    }

    class Todo
    {
        static void Main()
        {
            ProjectManager manager = new ProjectManager();

            // Get all methods from the ProjectManager class
            MethodInfo[] methods = typeof(ProjectManager).GetMethods();

            foreach (var method in methods)
            {
                // Check if the method has the Todo attribute
                var todoAttribute = (TodoAttribute)Attribute.GetCustomAttribute(method, typeof(TodoAttribute));

                if (todoAttribute != null)
                {
                    // Print task details
                    Console.WriteLine($"Method: {method.Name}");
                    Console.WriteLine($"Task: {todoAttribute.Task}");
                    Console.WriteLine($"Assigned To: {todoAttribute.AssignedTo}");
                    Console.WriteLine($"Priority: {todoAttribute.Priority}");
                    Console.WriteLine();
                }
            }
        }
    }

}
