//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Inheritance
//{
   

//    class Program
//    {
//        static void Main()
//        {
//            Author author = new Author("Malgudi Days", 1943, "R.K. Narayan", "An Indian writer known for his simple yet profound storytelling. His works, set in the fictional town of Malgudi, capture everyday life in India. Malgudi Days is a collection of short stories depicting various characters and their experiences in this small town.");
//            author.DisplayInfo();
//        }
//    }

//    class Book
//    {
//        protected string Title;
//        protected int PublicationYear;

//        public Book(string title, int publicationYear)
//        {
//            Title = title;
//            PublicationYear = publicationYear;
//        }

//        public virtual void DisplayInfo()
//        {
//            Console.WriteLine($"Title: {Title}");
//            Console.WriteLine($"Publication Year: {PublicationYear}");
//        }
//    }

//    class Author : Book
//    {
//        private string Name;
//        private string Bio;

//        public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
//        {
//            Name = name;
//            Bio = bio;
//        }

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//            Console.WriteLine($"Author: {Name}");
//            Console.WriteLine($"Bio: {Bio}");
//        }
//    }
//}
