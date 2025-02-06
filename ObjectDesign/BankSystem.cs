//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObjectDesign
//{
//    using System;
//    using System.Collections.Generic;

//    // Bank class
//    class Bank
//    {
//        public string Name { get; set; }
//        public List<Account> Accounts { get; set; }

//        public Bank(string name)
//        {
//            Name = name;
//            Accounts = new List<Account>();
//        }

//        public Account OpenAccount(Customer customer, decimal initialDeposit)
//        {
//            Account newAccount = new Account(customer, this, initialDeposit);
//            Accounts.Add(newAccount);
//            customer.AddAccount(newAccount);
//            Console.WriteLine($"Account opened for {customer.Name} at {Name} with balance {initialDeposit:C}");
//            return newAccount;
//        }
//    }

//    // Customer class
//    class Customer
//    {
//        public string Name { get; set; }
//        public List<Account> Accounts { get; set; }

//        public Customer(string name)
//        {
//            Name = name;
//            Accounts = new List<Account>();
//        }

//        public void AddAccount(Account account)
//        {
//            Accounts.Add(account);
//        }

//        public void ViewBalance()
//        {
//            Console.WriteLine($"{Name}'s Accounts:");
//            foreach (var account in Accounts)
//            {
//                Console.WriteLine($"Bank: {account.Bank.Name}, Balance: {account.Balance:C}");
//            }
//        }
//    }

//    // Account class
//    class Account
//    {
//        public Customer Owner { get; set; }
//        public Bank Bank { get; set; }
//        public decimal Balance { get; set; }

//        public Account(Customer owner, Bank bank, decimal initialDeposit)
//        {
//            Owner = owner;
//            Bank = bank;
//            Balance = initialDeposit;
//        }
//    }

//    class BankSystem
//    {
//        static void Main()
//        {
//            // Create banks
//            Console.Write("Enter the number of banks: ");
//            int bankCount = int.Parse(Console.ReadLine());
//            List<Bank> banks = new List<Bank>();

//            for (int i = 0; i < bankCount; i++)
//            {
//                Console.Write($"Enter name of bank {i + 1}: ");
//                string bankName = Console.ReadLine();
//                banks.Add(new Bank(bankName));
//            }

//            // Create customers
//            Console.Write("Enter the number of customers: ");
//            int customerCount = int.Parse(Console.ReadLine());
//            List<Customer> customers = new List<Customer>();

//            for (int i = 0; i < customerCount; i++)
//            {
//                Console.Write($"Enter name of customer {i + 1}: ");
//                string customerName = Console.ReadLine();
//                customers.Add(new Customer(customerName));
//            }

//            // Open accounts
//            foreach (Customer customer in customers)
//            {
//                Console.WriteLine($"{customer.Name}, choose a bank to open an account:");
//                for (int i = 0; i < banks.Count; i++)
//                {
//                    Console.WriteLine($"{i + 1}. {banks[i].Name}");
//                }
//                Console.Write("Enter choice: ");
//                int choice = int.Parse(Console.ReadLine()) - 1;

//                Console.Write("Enter initial deposit amount: ");
//                decimal initialDeposit = decimal.Parse(Console.ReadLine());

//                banks[choice].OpenAccount(customer, initialDeposit);
//            }

//            // View balances
//            foreach (Customer customer in customers)
//            {
//                customer.ViewBalance();
//            }
//        }
//    }
//}
