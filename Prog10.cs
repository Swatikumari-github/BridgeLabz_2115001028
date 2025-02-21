using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle
{
   

    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount cannot be negative.");
            }
            else if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient balance!");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful, new balance: {balance}");
            }
        }
    }

    class Prog10
    {
        static void Main()
        {
            try
            {
                // Create a bank account with an initial balance
                BankAccount account = new BankAccount(1000);

                // Taking withdrawal amount as input
                Console.WriteLine("Enter withdrawal amount:");
                double amount = Convert.ToDouble(Console.ReadLine());

                // Attempt to withdraw from the account
                account.Withdraw(amount);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);  // Handle insufficient balance
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid amount! " + ex.Message);  // Handle negative withdrawal amount
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");  // Handle invalid input format
            }
        }
    }

}
