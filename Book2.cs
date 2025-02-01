//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{
//    class Book
//    {
//        private string title;
//        private string author;
//        private double price;
//        private bool isAvailable;

//        // Default Constructor
//        public Book() : this("Unknown", "Unknown", 0.0, true) { }

//        // Parameterized Constructor
//        public Book(string title, string author, double price, bool isAvailable)
//        {
//            this.title = title;
//            this.author = author;
//            this.price = price;
//            this.isAvailable = isAvailable;
//        }

//        // BorrowBook Method
//        public void BorrowBook()
//        {
//            if (isAvailable)
//            {
//                isAvailable = false;
//                Console.WriteLine($"You have borrowed: {title}");
//            }
//            else
//            {
//                Console.WriteLine($"Sorry, {title} is not available.");
//            }
//        }

//        public void Display()
//        {
//            Console.WriteLine($"Title: {title}, Author: {author}, Price: ${price:F2}, Available: {isAvailable}");
//        }
//    }

//    // Example Usage
//    class Program
//    {
//        static void Main()
//        {
//            Book book1 = new Book("Happily Never After", "LYNN PAINTER", 399.5, true);
//            book1.Display();
//            book1.BorrowBook();
//            book1.Display();
//            book1.BorrowBook();
//        }
//    }
//}
