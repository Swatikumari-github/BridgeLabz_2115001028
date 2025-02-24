

namespace AnnotationReflection
{
    using System;
    using System.Reflection;

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class DynamicObj
    {
        static void Main()
        {
            // Get the Type object for the Student class
            Type studentType = typeof(Student);

            // Get the ConstructorInfo for the Student class with parameters (string, int)
            ConstructorInfo constructor = studentType.GetConstructor(new Type[] { typeof(string), typeof(int) });

            if (constructor != null)
            {
                // Dynamically create an instance of Student using the constructor
                object studentObject = constructor.Invoke(new object[] { "John Doe", 20 });

                // Use Reflection to call the DisplayInfo method
                MethodInfo methodInfo = studentType.GetMethod("DisplayInfo");

                // Invoke the DisplayInfo method on the created student object
                methodInfo.Invoke(studentObject, null);
            }
            else
            {
                Console.WriteLine("Constructor not found.");
            }
        }
    }

}
