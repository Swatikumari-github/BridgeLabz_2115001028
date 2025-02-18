namespace Generics
{
    using System;
    using System.Collections.Generic;

    // Abstract class representing a warehouse item
    public abstract class WarehouseItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public WarehouseItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void DisplayDetails();
    }

    // Electronics class
    public class Electronics : WarehouseItem
    {
        public string Brand { get; set; }

        public Electronics(string name, double price, string brand)
            : base(name, price)
        {
            Brand = brand;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"[Electronics] Name: {Name}, Price: {Price:C}, Brand: {Brand}");
        }
    }

    // Groceries class
    public class Groceries : WarehouseItem
    {
        public DateTime ExpiryDate { get; set; }

        public Groceries(string name, double price, DateTime expiryDate)
            : base(name, price)
        {
            ExpiryDate = expiryDate;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"[Groceries] Name: {Name}, Price: {Price:C}, Expiry: {ExpiryDate.ToShortDateString()}");
        }
    }

    // Furniture category
    public class Furniture : WarehouseItem
    {
        public string Material { get; set; }

        public Furniture(string name, double price, string material)
            : base(name, price)
        {
            Material = material;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"[Furniture] Name: {Name}, Price: {Price:C}, Material: {Material}");
        }
    }

    // Generic Storage class with type constraint
    public class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void DisplayAllItems()
        {
            foreach (var item in items)
            {
                item.DisplayDetails();
            }
        }
    }

   
    class Program
    {
        static void Main()
        {
            //  storage for different item categories
            Storage<Electronics> electronicsStorage = new Storage<Electronics>();
            Storage<Groceries> groceriesStorage = new Storage<Groceries>();
            Storage<Furniture> furnitureStorage = new Storage<Furniture>();

            // Add items
            electronicsStorage.AddItem(new Electronics("Laptop", 1700, "Dell"));
            electronicsStorage.AddItem(new Electronics("Smartphone", 700, "Samsung"));

            groceriesStorage.AddItem(new Groceries("Milk", 3.5, DateTime.Now.AddDays(7)));
            groceriesStorage.AddItem(new Groceries("Bread", 2.2, DateTime.Now.AddDays(3)));

            furnitureStorage.AddItem(new Furniture("Chair", 250, "Wood"));
            furnitureStorage.AddItem(new Furniture("Table", 500, "Metal"));

            // Display all items in each storage
            Console.WriteLine("\n--- Electronics Storage ---");
            electronicsStorage.DisplayAllItems();

            Console.WriteLine("\n--- Groceries Storage ---");
            groceriesStorage.DisplayAllItems();

            Console.WriteLine("\n--- Furniture Storage ---");
            furnitureStorage.DisplayAllItems();
        }
    }

}
