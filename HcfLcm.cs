using System;

class HcfLcm
{
    static int GetInput(string prompt)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            return number;
        }
        Console.WriteLine("Invalid input. Please enter a positive integer.");
        return GetInput(prompt);
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int LCM(int a, int b)
    {
        return (a / GCD(a, b)) * b;
    }

    static void DisplayResults(int a, int b, int gcd, int lcm)
    {
        Console.WriteLine($"GCD of {a} and {b} is {gcd}");
        Console.WriteLine($"LCM of {a} and {b} is {lcm}");
    }

    static void Main()
    {
        int num1 = GetInput("Enter the first number: ");
        int num2 = GetInput("Enter the second number: ");

        int gcd = GCD(num1, num2);
        int lcm = LCM(num1, num2);

        DisplayResults(num1, num2, gcd, lcm);
    }
}