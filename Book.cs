using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Title: "+Title);
        Console.WriteLine("Author: "+Author);
        Console.WriteLine("Price: "+Price);
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99);
        book1.DisplayDetails();
    }
}
