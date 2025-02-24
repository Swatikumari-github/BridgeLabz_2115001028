
using System;
using System.Diagnostics;
using System.Reflection;
namespace AnnotationReflection
{
   

    // Define the custom LogExecutionTime attribute
    [AttributeUsage(AttributeTargets.Method)]
    public class LogExecutionTimeAttribute : Attribute
    {
        // This attribute doesn't need any properties or fields
    }

    // Class with methods marked by the LogExecutionTime attribute
    class TaskManager
    {
        [LogExecutionTime]
        public void Task1()
        {
            // Simulate some work with a delay
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Task 1 executed.");
        }

        [LogExecutionTime]
        public void Task2()
        {
            // Simulate some work with a delay
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Task 2 executed.");
        }
    }

    class LoggingMethod
    {
        static void Main()
        {
            TaskManager manager = new TaskManager();

            // Get all methods from the TaskManager class
            MethodInfo[] methods = typeof(TaskManager).GetMethods();

            foreach (var method in methods)
            {
                // Check if the method has the LogExecutionTime attribute
                var logAttribute = (LogExecutionTimeAttribute)Attribute.GetCustomAttribute(method, typeof(LogExecutionTimeAttribute));

                if (logAttribute != null)
                {
                    // Start measuring execution time using Stopwatch
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    // Invoke the method using reflection
                    method.Invoke(manager, null);

                    // Stop measuring execution time
                    stopwatch.Stop();

                    // Print the execution time
                    Console.WriteLine($"Execution Time for {method.Name}: {stopwatch.ElapsedMilliseconds} ms\n");
                }
            }
        }
    }

}
