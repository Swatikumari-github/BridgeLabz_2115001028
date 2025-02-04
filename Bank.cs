//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops2
//{
//    using System;

//    class BankAccount
//    {
//        // Static variable shared by all accounts
//        public static string BankName = "ABC Bank";
//        private static int _accountCounter = 1000; // Auto-incrementing account numbers
//        private static int _totalAccounts = 0; // Keeps track of total accounts

//        // Readonly variable for account number
//        public readonly int AccountNumber;

//        // Properties
//        public string AccountHolderName { get; private set; }
//        public double Balance { get; private set; }

//        // Constructor using 'this' keyword to resolve ambiguity
//        public BankAccount(string accountHolderName, double initialDeposit)
//        {
//            this.AccountNumber = _accountCounter++;
//            this.AccountHolderName = accountHolderName;
//            this.Balance = initialDeposit;
//            _totalAccounts++; // Increment total accounts
//        }

//        // Static method to get total number of accounts
//        public static void GetTotalAccounts()
//        {
//            Console.WriteLine($"Total bank accounts created: {_totalAccounts}");
//        }

//        // Deposit method
//        public void Deposit(double amount)
//        {
//            if (amount > 0)
//            {
//                Balance += amount;
//                Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid deposit amount.");
//            }
//        }

//        // Withdraw method
//        public void Withdraw(double amount)
//        {
//            if (amount > 0 && amount <= Balance)
//            {
//                Balance -= amount;
//                Console.WriteLine($"Withdrawn {amount:C}. New Balance: {Balance:C}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
//            }
//        }

//        // Static method to check if an object is a BankAccount before displaying details
//        public static void DisplayAccountDetails(object obj)
//        {
//            if (obj is BankAccount account)
//            {
//                Console.WriteLine("\nAccount Details:");
//                Console.WriteLine($"Bank Name: {BankName}");
//                Console.WriteLine($"Account Number: {account.AccountNumber}");
//                Console.WriteLine($"Account Holder: {account.AccountHolderName}");
//                Console.WriteLine($"Balance: {account.Balance:C}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid account object.");
//            }
//        }
//    }

//    // Main program with user input
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Welcome to ABC Bank!");

//            // User input for account creation
//            Console.Write("Enter Account Holder Name: ");
//            string name = Console.ReadLine();

//            Console.Write("Enter Initial Deposit Amount: ");
//            double initialDeposit;
//            while (!double.TryParse(Console.ReadLine(), out initialDeposit) || initialDeposit < 0)
//            {
//                Console.Write("Invalid amount. Enter a valid deposit amount: ");
//            }

//            // Create a new bank account
//            BankAccount account = new BankAccount(name, initialDeposit);
//            Console.WriteLine("\nAccount created successfully!");

//            // Display account details using is operator
//            BankAccount.DisplayAccountDetails(account);

//            // Deposit money
//            Console.Write("\nEnter amount to deposit: ");
//            double depositAmount;
//            while (!double.TryParse(Console.ReadLine(), out depositAmount) || depositAmount < 0)
//            {
//                Console.Write("Invalid amount. Enter a valid deposit amount: ");
//            }
//            account.Deposit(depositAmount);

//            // Withdraw money
//            Console.Write("\nEnter amount to withdraw: ");
//            double withdrawAmount;
//            while (!double.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount < 0)
//            {
//                Console.Write("Invalid amount. Enter a valid withdrawal amount: ");
//            }
//            account.Withdraw(withdrawAmount);

//            // Display updated account details
//            BankAccount.DisplayAccountDetails(account);

//            // Display total accounts created
//            BankAccount.GetTotalAccounts();
//        }
//    }

//}
