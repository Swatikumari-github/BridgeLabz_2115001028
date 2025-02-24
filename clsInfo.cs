using System;
using System.Reflection;

namespace AnnotationReflection
{
  

    class ClsInfo
    {
        static void Main()
        {
            Console.Write("Enter the class name (e.g., SampleClass): ");
            string className = Console.ReadLine();

            // Get the Type object for the class
            Type type = Type.GetType(className);

            if (type != null)
            {
                // Displaying Methods of the Class
                Console.WriteLine("\nMethods:");
                MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                foreach (var method in methods)
                {
                    Console.WriteLine(method.Name);
                }

                // Displaying Fields of the Class
                Console.WriteLine("\nFields:");
                FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                foreach (var field in fields)
                {
                    Console.WriteLine(field.Name);
                }

                // Displaying Constructors of the Class
                Console.WriteLine("\nConstructors:");
                ConstructorInfo[] constructors = type.GetConstructors();
                foreach (var constructor in constructors)
                {
                    Console.WriteLine(constructor.ToString());
                }
            }
            else
            {
                Console.WriteLine("Class not found.");
            }
        }
    }

    public class SampleClass
    {
        public string Name;
        private int age;

        public SampleClass(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {age}");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }
    }

}
