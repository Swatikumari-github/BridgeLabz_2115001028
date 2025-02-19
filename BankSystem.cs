using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
   
    class BankingSystem
    {
        // Dictionary to store account balances
        private Dictionary<int, double> accountBalances = new Dictionary<int, double>();

        // SortedDictionary to store customers by balance
        private SortedDictionary<int, double> sortedByBalance = new SortedDictionary<int, double>();

        // Queue to process withdrawal requests
        private Queue<string> withdrawalRequests = new Queue<string>();

        // Add a customer to the system
        public void AddCustomer(int accountNumber, double initialBalance)
        {
            accountBalances[accountNumber] = initialBalance;
            sortedByBalance[accountNumber] = initialBalance;
        }

        // Deposit money into an account
        public void Deposit(int accountNumber, double amount)
        {
            if (accountBalances.ContainsKey(accountNumber))
            {
                accountBalances[accountNumber] += amount;

                // Update the sorted balance dictionary
                sortedByBalance.Remove(accountNumber);
                sortedByBalance[accountNumber] = accountBalances[accountNumber];
                Console.WriteLine($"Deposited {amount:C} to account {accountNumber}. New balance: {accountBalances[accountNumber]:C}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Withdraw money from an account
        public void Withdraw(int accountNumber, double amount)
        {
            if (accountBalances.ContainsKey(accountNumber))
            {
                if (accountBalances[accountNumber] >= amount)
                {
                    withdrawalRequests.Enqueue($"Withdraw {amount:C} from account {accountNumber}");
                    Console.WriteLine($"Withdrawal request queued: {amount:C} from account {accountNumber}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Process withdrawal requests
        public void ProcessWithdrawals()
        {
            while (withdrawalRequests.Count > 0)
            {
                string request = withdrawalRequests.Dequeue();
                Console.WriteLine($"Processing request: {request}");
                string[] requestDetails = request.Split(' ');

                double amount = double.Parse(requestDetails[1].Replace("$", ""));
                int accountNumber = int.Parse(requestDetails[4]);

                if (accountBalances[accountNumber] >= amount)
                {
                    accountBalances[accountNumber] -= amount;
                    // Update the sorted balance dictionary
                    sortedByBalance.Remove(accountNumber);
                    sortedByBalance[accountNumber] = accountBalances[accountNumber];
                    Console.WriteLine($"Processed: {amount:C} withdrawn from account {accountNumber}. New balance: {accountBalances[accountNumber]:C}");
                }
                else
                {
                    Console.WriteLine($"Insufficient balance to withdraw {amount:C} from account {accountNumber}");
                }
            }
        }

        // View the balance of a particular account
        public void ViewBalance(int accountNumber)
        {
            if (accountBalances.ContainsKey(accountNumber))
            {
                Console.WriteLine($"Account {accountNumber} balance: {accountBalances[accountNumber]:C}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Display customers sorted by balance
        public void DisplaySortedCustomers()
        {
            Console.WriteLine("\nCustomers sorted by balance:");
            foreach (var customer in sortedByBalance)
            {
                Console.WriteLine($"Account {customer.Key}: {customer.Value:C}");
            }
        }
    }

    class BankSystem
        {
        static void Main()
        {
            BankingSystem bank = new BankingSystem();

            // Add some customers
            bank.AddCustomer(1001, 5000.00);
            bank.AddCustomer(1002, 10000.00);
            bank.AddCustomer(1003, 1500.00);

            // Deposit some money
            bank.Deposit(1001, 2000.00);
            bank.Deposit(1003, 500.00);

            // Withdraw some money
            bank.Withdraw(1002, 3000.00);
            bank.Withdraw(1001, 1000.00);
            bank.Withdraw(1003, 2500.00); // This will fail due to insufficient funds

            // Process withdrawal requests
            bank.ProcessWithdrawals();

            // View balances
            bank.ViewBalance(1001);
            bank.ViewBalance(1002);
            bank.ViewBalance(1003);

            // Display sorted customers
            bank.DisplaySortedCustomers();
        }
    }

}
