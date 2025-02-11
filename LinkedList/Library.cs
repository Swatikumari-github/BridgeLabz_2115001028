//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinkedList
//{
 

//    class Book
//    {
//        public string Title { get; set; }
//        public string Author { get; set; }
//        public string Genre { get; set; }
//        public int Id { get; set; }
//        public bool IsAvailable { get; set; }
//        public Book Next { get; set; }
//        public Book Prev { get; set; }

//        public Book(string title, string author, string genre, int id, bool isAvailable)
//        {
//            Title = title;
//            Author = author;
//            Genre = genre;
//            Id = id;
//            IsAvailable = isAvailable;
//            Next = Prev = null;
//        }
//    }

//    class Library
//    {
//        private Book head, tail;
//        private int count;

//        public void AddAtBeginning(string title, string author, string genre, int id, bool isAvailable)
//        {
//            Book newBook = new Book(title, author, genre, id, isAvailable);
//            if (head == null)
//            {
//                head = tail = newBook;
//            }
//            else
//            {
//                newBook.Next = head;
//                head.Prev = newBook;
//                head = newBook;
//            }
//            count++;
//        }

//        public void AddAtEnd(string title, string author, string genre, int id, bool isAvailable)
//        {
//            Book newBook = new Book(title, author, genre, id, isAvailable);
//            if (tail == null)
//            {
//                head = tail = newBook;
//            }
//            else
//            {
//                tail.Next = newBook;
//                newBook.Prev = tail;
//                tail = newBook;
//            }
//            count++;
//        }

//        public void RemoveById(int id)
//        {
//            if (head == null) return;
//            if (head.Id == id)
//            {
//                head = head.Next;
//                if (head != null) head.Prev = null;
//                count--;
//                return;
//            }
//            Book temp = head;
//            while (temp != null && temp.Id != id)
//            {
//                temp = temp.Next;
//            }
//            if (temp == null) return;
//            if (temp.Next != null) temp.Next.Prev = temp.Prev;
//            if (temp.Prev != null) temp.Prev.Next = temp.Next;
//            if (temp == tail) tail = temp.Prev;
//            count--;
//        }

//        public Book SearchByTitle(string title)
//        {
//            Book temp = head;
//            while (temp != null)
//            {
//                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase)) return temp;
//                temp = temp.Next;
//            }
//            return null;
//        }

//        public void UpdateAvailability(int id, bool status)
//        {
//            Book temp = head;
//            while (temp != null)
//            {
//                if (temp.Id == id)
//                {
//                    temp.IsAvailable = status;
//                    return;
//                }
//                temp = temp.Next;
//            }
//        }

//        public void DisplayForward()
//        {
//            Book temp = head;
//            while (temp != null)
//            {
//                Console.WriteLine($"Book: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, ID: {temp.Id}, Available: {temp.IsAvailable}");
//                temp = temp.Next;
//            }
//        }

//        public void DisplayReverse()
//        {
//            Book temp = tail;
//            while (temp != null)
//            {
//                Console.WriteLine($"Book: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, ID: {temp.Id}, Available: {temp.IsAvailable}");
//                temp = temp.Prev;
//            }
//        }

//        public int CountBooks()
//        {
//            return count;
//        }
//    }

//    class LibraryManagement
//    {
//        static void Main()
//        {
//            Library library = new Library();
//            library.AddAtEnd("Malgudi Days", "R.K. Narayan", "Fiction", 201, true);
//            library.AddAtEnd("Godan", "Munshi Premchand", "Classic", 202, false);
//            library.AddAtBeginning("The Guide", "R.K. Narayan", "Drama", 203, true);
//            library.AddAtEnd("Gitanjali", "Rabindranath Tagore", "Poetry", 204, true);

//            Console.WriteLine("Library Books (Forward Order):");
//            library.DisplayForward();

//            Console.WriteLine("Library Books (Reverse Order):");
//            library.DisplayReverse();

//            Console.WriteLine("Total Books: " + library.CountBooks());

//            Book searchResult = library.SearchByTitle("Godan");
//            if (searchResult != null)
//            {
//                Console.WriteLine("Book Found: " + searchResult.Title + " by " + searchResult.Author);
//            }
//            else
//            {
//                Console.WriteLine("Book not found.");
//            }

//            library.UpdateAvailability(202, true);
//            Console.WriteLine("Updated Library:");
//            library.DisplayForward();

//            library.RemoveById(203);
//            Console.WriteLine("Library after removing a book:");
//            library.DisplayForward();
//        }
//    }

//}
