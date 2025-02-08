using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class Program
    {
        static void Main()
        {
            SavingsAccount savings = new SavingsAccount("SA12345", 5000, 3.5);
            CheckingAccount checking = new CheckingAccount("CA67890", 2000, 1000);
            FixedDepositAccount fixedDeposit = new FixedDepositAccount("FD11223", 10000, 12);


            savings.DisplayAccountInfo();
            savings.DisplayAccountType();
            Console.WriteLine();

            checking.DisplayAccountInfo();
            checking.DisplayAccountType();
            Console.WriteLine();

            fixedDeposit.DisplayAccountInfo();
            fixedDeposit.DisplayAccountType();
        }
    }

    class BankAccount
    {
        protected string AccountNumber;
        protected double Balance;

        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: ${Balance}");
        }
    }

    class SavingsAccount : BankAccount
    {
        private double InterestRate;

        public SavingsAccount(string accountNumber, double balance, double interestRate) : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Savings Account");
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }

    class CheckingAccount : BankAccount
    {
        private double WithdrawalLimit;

        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit) : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Checking Account");
            Console.WriteLine($"Withdrawal Limit: ${WithdrawalLimit}");
        }
    }

    class FixedDepositAccount : BankAccount
    {
        private int MaturityPeriod;

        public FixedDepositAccount(string accountNumber, double balance, int maturityPeriod) : base(accountNumber, balance)
        {
            MaturityPeriod = maturityPeriod;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Fixed Deposit Account");
            Console.WriteLine($"Maturity Period: {MaturityPeriod} months");
        }
    }
}
