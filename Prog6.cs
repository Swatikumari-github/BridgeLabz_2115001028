using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle
{
    using System;

    class Prog6
    {
        static double CalculateInterest(double amount, double rate, int years)
        {
            if (amount < 0 || rate < 0)
            {
                throw new ArgumentException("Amount and rate must be positive");
            }

            return amount * Math.Pow(1 + rate / 100, years) - amount;
        }

        static void Main()
        {
            try
            {
                Console.Write("Enter amount: ");
                double amount = double.Parse(Console.ReadLine());

                Console.Write("Enter rate: ");
                double rate = double.Parse(Console.ReadLine());

                Console.Write("Enter years: ");
                int years = int.Parse(Console.ReadLine());

                double interest = CalculateInterest(amount, rate, years);
                Console.WriteLine($"Calculated Interest: {interest}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input: Please enter numeric values.");
            }
        }
    }
}
