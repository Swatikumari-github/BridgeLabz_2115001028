//using System;

//class Book
//{
//    public static string LibraryName = "GLA Central Library";
//    public readonly string ISBN;
//    private string Title;
//    private string Author;

//    public Book(string title, string author, string isbn)
//    {
//        this.Title = title;
//        this.Author = author;
//        this.ISBN = isbn;
//    }

//    public static void DisplayLibraryName()
//    {
//        Console.WriteLine("Library Name: " + LibraryName);
//    }

//    public void DisplayDetails()
//    {
//        if (this is Book)
//        {
//            Console.WriteLine("Title: " + this.Title + ", Author: " + this.Author + ", ISBN: " + this.ISBN);
//        }
//        else
//        {
//            Console.WriteLine("Invalid book object!");
//        }
//    }

//    static void Main(string[] args)
//    {
//        DisplayLibraryName();

//        Console.Write("Enter Book Title: ");
//        string title = Console.ReadLine();

//        Console.Write("Enter Author Name: ");
//        string author = Console.ReadLine();

//        Console.Write("Enter ISBN: ");
//        string isbn = Console.ReadLine();

//        Book userBook = new Book(title, author, isbn);
//        userBook.DisplayDetails();
//    }
//}