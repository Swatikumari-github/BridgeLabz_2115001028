using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   

    // Interface for product categories
    public interface ICategory
    {
        string CategoryName { get; }
    }

    // Book category
    public class BookCategory : ICategory
    {
        public string CategoryName => "Books";
    }

    // Cloth category
    public class ClothingCategory : ICategory
    {
        public string CategoryName => "Clothing";
    }

    // Generic Product class restricted to ICategory
    public class Product<T> where T : ICategory
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public T Category { get; set; }

        public Product(string name, double price, T category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"[Category: {Category.CategoryName}] Name: {Name}, Price: {Price:C}");
        }
    }

    // Generic Marketplace Catalog
    public class Marketplace
    {
        private List<object> products = new List<object>();

        public void AddProduct<T>(Product<T> product) where T : ICategory
        {
            products.Add(product);
        }

        public void ShowCatalog()
        {
            foreach (var product in products)
            {
                if (product is IDisplayable displayableProduct)
                {
                    displayableProduct.DisplayProduct();
                }
            }
        }

        // Generic Method to Apply Discount
        public void ApplyDiscount<T>(Product<T> product, double percentage) where T : ICategory
        {
            product.Price -= product.Price * (percentage / 100);
            Console.WriteLine($"Discount applied: {percentage}% off on {product.Name}. New Price: {product.Price:C}");
        }
    }

    // Interface to display products
    public interface IDisplayable
    {
        void DisplayProduct();
    }

    //  Product class is extended to implement display functionality
    public static class ProductExtensions
    {
        public static void DisplayProduct<T>(this Product<T> product) where T : ICategory
        {
            Console.WriteLine($"[Category: {product.Category.CategoryName}] Name: {product.Name}, Price: {product.Price:C}");
        }
    }

    // Main Program
    class MarketPlace
    {
        static void Main()
        {
            Marketplace marketplace = new Marketplace();

            // Create categories
            BookCategory bookCategory = new BookCategory();
            ClothingCategory clothingCategory = new ClothingCategory();

            // Create products
            Product<BookCategory> book1 = new Product<BookCategory>("C# Programming", 39.99, bookCategory);
            Product<ClothingCategory> tshirt = new Product<ClothingCategory>("Graphic T-Shirt", 19.99, clothingCategory);

            // Add products to marketplace
            marketplace.AddProduct(book1);
            marketplace.AddProduct(tshirt);

            // Display catalog before discount
            Console.WriteLine("\n--- Marketplace Catalog Before Discount ---");
            marketplace.ShowCatalog();

            // Apply discount
            marketplace.ApplyDiscount(book1, 10);
            marketplace.ApplyDiscount(tshirt, 15);

            // Display catalog after discount
            Console.WriteLine("\n--- Marketplace Catalog After Discount ---");
            marketplace.ShowCatalog();
        }
    }

}
