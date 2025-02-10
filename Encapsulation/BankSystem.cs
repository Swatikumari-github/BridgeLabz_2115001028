//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Encapsulation
//{
//    using System;

//    // Abstract class for Bank Account
//    abstract class BankAccount
//    {
//        protected string accountNumber;
//        protected string holderName;
//        protected double balance;

//        public BankAccount(string accountNumber, string holderName, double balance)
//        {
//            this.accountNumber = accountNumber;
//            this.holderName = holderName;
//            this.balance = balance;
//        }

//        public void Deposit(double amount)
//        {
//            balance += amount;
//            Console.WriteLine($"Deposited {amount}. New Balance: {balance}");
//        }

//        public virtual void Withdraw(double amount)
//        {
//            if (amount <= balance)
//            {
//                balance -= amount;
//                Console.WriteLine($"Withdrawn {amount}. New Balance: {balance}");
//            }
//            else
//            {
//                Console.WriteLine("Insufficient balance!");
//            }
//        }

//        public abstract void CalculateInterest();
//    }

//    // Interface for Loan
//    interface ILoanable
//    {
//        void ApplyForLoan(double amount);
//        bool CalculateLoanEligibility();
//    }

//    // Savings Account class
//    class SavingsAccount : BankAccount
//    {
//        private double interestRate = 0.04; // 4% interest

//        public SavingsAccount(string accountNumber, string holderName, double balance)
//            : base(accountNumber, holderName, balance) { }

//        public override void CalculateInterest()
//        {
//            double interest = balance * interestRate;
//            Console.WriteLine($"Interest Earned: {interest}");
//        }
//    }

//    // Current Account class
//    class CurrentAccount : BankAccount, ILoanable
//    {
//        private double interestRate = 0.02; // 2% interest

//        public CurrentAccount(string accountNumber, string holderName, double balance)
//            : base(accountNumber, holderName, balance) { }

//        public override void CalculateInterest()
//        {
//            double interest = balance * interestRate;
//            Console.WriteLine($"Interest Earned: {interest}");
//        }

//        public void ApplyForLoan(double amount)
//        {
//            Console.WriteLine($"Loan application submitted for {amount}");
//        }

//        public bool CalculateLoanEligibility()
//        {
//            return balance >= 5000; // Minimum balance requirement
//        }
//    }

//    class BankSystem
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter Account Type (1 for Savings, 2 for Current): ");
//            int choice = int.Parse(Console.ReadLine());

//            Console.Write("Enter Account Number: ");
//            string accNumber = Console.ReadLine();

//            Console.Write("Enter Holder Name: ");
//            string holderName = Console.ReadLine();

//            Console.Write("Enter Initial Balance: ");
//            double balance = double.Parse(Console.ReadLine());

//            BankAccount account;

//            if (choice == 1)
//            {
//                account = new SavingsAccount(accNumber, holderName, balance);
//            }
//            else
//            {
//                account = new CurrentAccount(accNumber, holderName, balance);
//            }

//            account.Deposit(1000);
//            account.Withdraw(500);
//            account.CalculateInterest();

//            if (account is ILoanable loanableAccount)
//            {
//                Console.WriteLine("Applying for loan...");
//                loanableAccount.ApplyForLoan(10000);
//                Console.WriteLine($"Loan Eligibility: {loanableAccount.CalculateLoanEligibility()}");
//            }
//        }
//    }

//}
