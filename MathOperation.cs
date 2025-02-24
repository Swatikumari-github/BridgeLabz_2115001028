

namespace AnnotationReflection
{

    using System;
    using System.Reflection;

    public class MathOperations
    {
        // Method to add two numbers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to subtract two numbers
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method to multiply two numbers
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Mathoperation
    {
        static void Main()
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Get the Type object for MathOperations
            Type mathOpsType = typeof(MathOperations);

            // Prompt the user for the operation to perform
            Console.WriteLine("Enter the operation you want to perform (Add, Subtract, Multiply): ");
            string operation = Console.ReadLine();

            // Get the MethodInfo for the selected method
            MethodInfo methodInfo = mathOpsType.GetMethod(operation, BindingFlags.Public | BindingFlags.Instance);

            if (methodInfo != null)
            {
                // Prompt for two numbers to pass to the method
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                // Dynamically invoke the method with the numbers
                object result = methodInfo.Invoke(mathOps, new object[] { num1, num2 });

                // Display the result
                Console.WriteLine($"Result of {operation}: {result}");
            }
            else
            {
                Console.WriteLine($"Method {operation} not found.");
            }
        }
    }

}
