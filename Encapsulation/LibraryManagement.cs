//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Encapsulation
//{
//    using System;
//    using System.Collections.Generic;

//    // Abstract class for Library Items
//    abstract class LibraryItem
//    {
//        protected string itemId;
//        protected string title;
//        protected string author;

//        public LibraryItem(string itemId, string title, string author)
//        {
//            this.itemId = itemId;
//            this.title = title;
//            this.author = author;
//        }

//        public void GetItemDetails()
//        {
//            Console.WriteLine($"ID: {itemId}, Title: {title}, Author: {author}");
//        }

//        public abstract int GetLoanDuration();
//    }

//    // Interface for Reservable Items
//    interface IReservable
//    {
//        void ReserveItem();
//        bool CheckAvailability();
//    }

//    // Book subclass
//    class Book : LibraryItem, IReservable
//    {
//        public Book(string itemId, string title, string author) : base(itemId, title, author) { }

//        public override int GetLoanDuration()
//        {
//            return 14; // 14 days loan duration
//        }

//        public void ReserveItem()
//        {
//            Console.WriteLine("Book reserved successfully.");
//        }

//        public bool CheckAvailability()
//        {
//            return true; // Assume book is available
//        }
//    }

//    // Magazine subclass
//    class Magazine : LibraryItem
//    {
//        public Magazine(string itemId, string title, string author) : base(itemId, title, author) { }

//        public override int GetLoanDuration()
//        {
//            return 7; // 7 days loan duration
//        }
//    }

//    // DVD subclass
//    class DVD : LibraryItem, IReservable
//    {
//        public DVD(string itemId, string title, string author) : base(itemId, title, author) { }

//        public override int GetLoanDuration()
//        {
//            return 5; // 5 days loan duration
//        }

//        public void ReserveItem()
//        {
//            Console.WriteLine("DVD reserved successfully.");
//        }

//        public bool CheckAvailability()
//        {
//            return false; // Assume DVD is currently unavailable
//        }
//    }

//    class LibraryManagement
//    {
//        static void Main()
//        {
//            List<LibraryItem> items = new List<LibraryItem>();

//            Console.WriteLine("Enter Library Item Type (1 for Book, 2 for Magazine, 3 for DVD): ");
//            int choice = int.Parse(Console.ReadLine());

//            Console.Write("Enter Item ID: ");
//            string itemId = Console.ReadLine();

//            Console.Write("Enter Title: ");
//            string title = Console.ReadLine();

//            Console.Write("Enter Author: ");
//            string author = Console.ReadLine();

//            LibraryItem item;

//            switch (choice)
//            {
//                case 1:
//                    item = new Book(itemId, title, author);
//                    break;
//                case 2:
//                    item = new Magazine(itemId, title, author);
//                    break;
//                case 3:
//                    item = new DVD(itemId, title, author);
//                    break;
//                default:
//                    Console.WriteLine("Invalid choice.");
//                    return;
//            }

//            items.Add(item);
//            item.GetItemDetails();
//            Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

//            if (item is IReservable reservableItem)
//            {
//                Console.WriteLine("Checking availability...");
//                Console.WriteLine($"Availability: {reservableItem.CheckAvailability()}");
//                reservableItem.ReserveItem();
//            }
//        }
//    }

//}
