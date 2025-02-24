using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationReflection
{
    using System;
    using System.Reflection;

    // Define the custom attribute ImportantMethod with an optional Level parameter
    [AttributeUsage(AttributeTargets.Method)]
    public class ImportantMethodAttribute : Attribute
    {
        public string Level { get; }

        // Constructor with optional parameter
        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }

    // Class with methods marked by the ImportantMethod attribute
    class TaskManager
    {
        [ImportantMethod("HIGH")]
        public void CriticalTask()
        {
            Console.WriteLine("Critical Task is being executed.");
        }

        [ImportantMethod("MEDIUM")]
        public void RoutineTask()
        {
            Console.WriteLine("Routine Task is being executed.");
        }

        [ImportantMethod] // Default "HIGH" level
        public void EmergencyTask()
        {
            Console.WriteLine("Emergency Task is being executed.");
        }
    }

    class Important
    {
        static void Main()
        {
            TaskManager taskManager = new TaskManager();

            // Get all methods from TaskManager class
            MethodInfo[] methods = typeof(TaskManager).GetMethods();

            foreach (var method in methods)
            {
                // Check if the method has the ImportantMethod attribute
                var importantAttribute = (ImportantMethodAttribute)Attribute.GetCustomAttribute(method, typeof(ImportantMethodAttribute));

                if (importantAttribute != null)
                {
                    // Print method name and its importance level
                    Console.WriteLine($"Method: {method.Name} | Importance Level: {importantAttribute.Level}");
                }
            }
        }
    }

}
