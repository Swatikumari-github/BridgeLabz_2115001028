using System;

class BasicCalculator
{
    // Function for addition
    static double Add(double x, double y)
    {
        return x + y;
    }

    // Function for subtraction
    static double Subtract(double x, double y)
    {
        return x - y;
    }

    // Function for multiplication
    static double Multiply(double x, double y)
    {
        return x * y;
    }

    // Function for division
    static double Divide(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Error! Division by zero.");
            return double.NaN;
        }
        else
        {
            return x / y;
        }
    }

    // Main method to drive the calculator
    static void Main()
    {
        double num1, num2;
        int choice;

        Console.WriteLine("Select operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("Enter choice (1/2/3/4): ");
        choice = Convert.ToInt32(Console.ReadLine());

        // Taking user input for the numbers
        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Perform the selected operation
        switch (choice)
        {
            case 1:
                Console.WriteLine(num1 +"+" +num2  +"=" +Add(num1, num2));
                break;
            case 2:
                Console.WriteLine(num1 +"-" +num2  +"=" +Subtract(num1, num2));
                break;
            case 3:
                Console.WriteLine(num1 +"*" +num2  +"=" +Multiply(num1, num2));
                break;
            case 4:
                Console.WriteLine(num1 +"/" +num2  +"=" +Divide(num1, num2));
                break;
            default:
                Console.WriteLine("Invalid input! Please select a valid operation.");
                break;
        }
    }
}
