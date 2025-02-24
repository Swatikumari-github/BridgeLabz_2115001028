using System;
using System.Reflection;

namespace AnnotationReflection
{
   

    public class Calculator1
    {
        // Private method to multiply two integers
        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class InvokePrivate
    {
        static void Main()
        {
            // Create an instance of the Calculator class
            Calculator calculator = new Calculator();

            // Use Reflection to get the private method 'Multiply'
            Type calculatorType = typeof(Calculator);
            MethodInfo methodInfo = calculatorType.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

            if (methodInfo != null)
            {
                // Invoke the private method with arguments 5 and 6
                object result = methodInfo.Invoke(calculator, new object[] { 5, 6 });

                // Display the result of the multiplication
                Console.WriteLine("Multiplication Result: " + result);
            }
            else
            {
                Console.WriteLine("Method 'Multiply' not found.");
            }
        }
    }

}
