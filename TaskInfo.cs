//using System;
//using System.Reflection;

//namespace AnnotationReflection
//{
   

//    //  custom attribute
//    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
//    public class TaskInfoAttribute : Attribute
//    {
//        public int Priority { get; }
//        public string AssignedTo { get; }

//        public TaskInfoAttribute(int priority, string assignedTo)
//        {
//            Priority = priority;
//            AssignedTo = assignedTo;
//        }
//    }

//    // TaskManager class with methods marked by TaskInfo
//    class TaskManager
//    {
//        [TaskInfo(1, "John Doe")]
//        public void Task1()
//        {
//            Console.WriteLine("Task 1 is being executed.");
//        }

//        [TaskInfo(2, "Jane Smith")]
//        public void Task2()
//        {
//            Console.WriteLine("Task 2 is being executed.");
//        }
//    }

//    class TaskInfo
//    {
//        static void Main()
//        {
//            TaskManager manager = new TaskManager();

//            // Get the methods of TaskManager class
//            MethodInfo[] methods = typeof(TaskManager).GetMethods();

//            foreach (var method in methods)
//            {
//                // Check if the method has the TaskInfo attribute
//                var attribute = (TaskInfoAttribute)Attribute.GetCustomAttribute(method, typeof(TaskInfoAttribute));

//                if (attribute != null)
//                {
//                    Console.WriteLine($"Method: {method.Name}");
//                    Console.WriteLine($"Priority: {attribute.Priority}");
//                    Console.WriteLine($"Assigned To: {attribute.AssignedTo}");
//                    Console.WriteLine();
//                }
//            }
//        }
//    }

//}
