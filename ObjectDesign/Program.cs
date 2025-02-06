//namespace ObjectDesign
//{
//    using System;
//    using System.Collections.Generic;

//    // Book class (can exist independently of Library)
//    class Book
//    {
//        public string Title { get; set; }
//        public string Author { get; set; }

//        public Book(string title, string author)
//        {
//            Title = title;
//            Author = author;
//        }

//        public void Display()
//        {
//            Console.WriteLine($"Book: {Title}, Author: {Author}");
//        }
//    }

//    // Library class (aggregates books but does not own them exclusively)
//    class Library
//    {
//        public string Name { get; set; }
//        public List<Book> Books { get; set; }

//        public Library(string name)
//        {
//            Name = name;
//            Books = new List<Book>();
//        }

//        public void AddBook(Book book)
//        {
//            Books.Add(book);
//        }

//        public void ShowBooks()
//        {
//            Console.WriteLine($"Library: {Name}");
//            foreach (var book in Books)
//            {
//                book.Display();
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating books
//            List<Book> allBooks = new List<Book>
//        {
//            new Book("Alice in Wonderland", "Lewis Carrol"),
//            new Book("Animal Farm", "George Orwell"),
//            new Book("Ancient Mariner", "Coleridge")
//        };

//            // Creating libraries
//            Library library1 = new Library("Central Library");
//            Library library2 = new Library("University Library");

//            // Asking user which books to add to libraries
//            foreach (var book in allBooks)
//            {
//                Console.WriteLine($"Do you want to add '{book.Title}' to {library1.Name}? (yes/no)");
//                string response1 = Console.ReadLine().Trim().ToLower();
//                if (response1 == "yes")
//                {
//                    library1.AddBook(book);
//                }

//                Console.WriteLine($"Do you want to add '{book.Title}' to {library2.Name}? (yes/no)");
//                string response2 = Console.ReadLine().Trim().ToLower();
//                if (response2 == "yes")
//                {
//                    library2.AddBook(book);
//                }
//            }

//            // Display books in each library
//            Console.WriteLine();
//            library1.ShowBooks();
//            Console.WriteLine();
//            library2.ShowBooks();
//        }
//    }


//}
