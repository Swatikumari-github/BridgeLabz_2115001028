//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{
//    using System;

//    class Book
//    {
//        // Public field (accessible from anywhere)
//        public string ISBN;

//        // Protected field (accessible within this class and derived classes)
//        protected string title;

//        // Private field (accessible only within this class)
//        private string author;

//        // Constructor to initialize the book details
//        public Book(string ISBN, string title, string author)
//        {
//            this.ISBN = ISBN;
//            this.title = title;
//            this.author = author;
//        }

//        // Public method to get the author name
//        public string GetAuthor()
//        {
//            return author;
//        }

//        // Public method to set the author name
//        public void SetAuthor(string authorName)
//        {
//            author = authorName;
//        }

//        // Method to display book details (for testing purposes)
//        public void DisplayBookDetails()
//        {
//            Console.WriteLine($"ISBN: {ISBN}");
//            Console.WriteLine($"Title: {title}");
//            Console.WriteLine($"Author: {author}");
//        }
//    }

//    // Subclass that demonstrates the use of access modifiers
//    class EBook : Book
//    {
//        // Constructor to initialize EBook details
//        public EBook(string ISBN, string title, string author)
//            : base(ISBN, title, author)  // Calling base class constructor
//        {
//        }

//        // Method to display EBook details (accessing protected and public members)
//        public void DisplayEBookDetails()
//        {
//            Console.WriteLine($"EBook ISBN: {ISBN}");  // Accessing public field ISBN
//            Console.WriteLine($"EBook Title: {title}");  // Accessing protected field title
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating an instance of Book class
//            Book book1 = new Book("978-123-09", "The Great Book", "XYZ");

//            // Displaying book details
//            Console.WriteLine("Book Details:");
//            book1.DisplayBookDetails();

//            // Using public methods to access and modify the author name
//            Console.WriteLine("\nModifying and accessing author name:");
//            book1.SetAuthor("John Smith");
//            Console.WriteLine($"Updated Author: {book1.GetAuthor()}");

//            // Creating an instance of EBook class
//            EBook eBook1 = new EBook("978-0-123-45678-9", "The Digital Book", "ABC");

//            // Displaying EBook details (accessing ISBN and title)
//            Console.WriteLine("\nEBook Details:");
//            eBook1.DisplayEBookDetails();
//        }
//    }

//}
