//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{


//    class BankAccount
//    {
//        // Public field (accessible from anywhere)
//        public string accountNumber;

//        // Protected field (accessible within this class and derived classes)
//        protected string accountHolder;

//        // Private field (accessible only within this class)
//        private double balance;

//        // Constructor to initialize account details
//        public BankAccount(string accountNumber, string accountHolder, double balance)
//        {
//            this.accountNumber = accountNumber;
//            this.accountHolder = accountHolder;
//            this.balance = balance;
//        }

//        // Public method to get the balance
//        public double GetBalance()
//        {
//            return balance;
//        }

//        // Public method to modify the balance
//        public void SetBalance(double newBalance)
//        {
//            balance = newBalance;
//        }

//        // Method to display account details (for testing purposes)
//        public void DisplayAccountDetails()
//        {
//            Console.WriteLine($"Account Number: {accountNumber}");
//            Console.WriteLine($"Account Holder: {accountHolder}");
//            Console.WriteLine($"Balance: ${balance}");
//        }
//    }

//    // Subclass to demonstrate the use of access modifiers
//    class SavingsAccount : BankAccount
//    {
//        // Constructor to initialize savings account details
//        public SavingsAccount(string accountNumber, string accountHolder, double balance)
//            : base(accountNumber, accountHolder, balance)  // Calling base class constructor
//        {
//        }

//        // Method to display savings account details (accessing public and protected members)
//        public void DisplaySavingsAccountDetails()
//        {
//            Console.WriteLine($"Savings Account - Account Number: {accountNumber}");  // Accessing public field accountNumber
//            Console.WriteLine($"Account Holder: {accountHolder}");  // Accessing protected field accountHolder
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating an instance of BankAccount class
//            BankAccount bankAccount1 = new BankAccount("1234567890", "swati", 1500.50);

//            // Displaying account details
//            Console.WriteLine("Bank Account Details:");
//            bankAccount1.DisplayAccountDetails();

//            // Using public methods to access and modify the balance
//            Console.WriteLine("\nModifying and accessing balance:");
//            Console.WriteLine($"Current Balance: ${bankAccount1.GetBalance()}");
//            bankAccount1.SetBalance(1800.75);  // Modifying balance
//            Console.WriteLine($"Updated Balance: ${bankAccount1.GetBalance()}");

//            // Creating an instance of SavingsAccount class
//            SavingsAccount savingsAccount1 = new SavingsAccount("9876543210", "sumit", 2500.00);

//            // Displaying savings account details (accessing accountNumber and accountHolder)
//            Console.WriteLine("\nSavings Account Details:");
//            savingsAccount1.DisplaySavingsAccountDetails();
//        }
//    }

//}
