using System;
using System.IO;

namespace ExceptionHandle
{
    

    namespace Exception
    {


        class Prog2
        {
            static void Main()
            {
                HandleFileReading();
                HandleDivision();
            }

            static void HandleFileReading()
            {
                string filePath = "data.txt";

                try
                {
                    // Attempt to read the file
                    string content = File.ReadAllText(filePath);
                    Console.WriteLine("File Contents:");
                    Console.WriteLine(content);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found.");
                }
                catch (IOException ex)
                {
                    Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
                }
            }

            static void HandleDivision()
            {
                try
                {
                    Console.Write("Enter the first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid numeric value.");
                }
            }
        }

    }


}
