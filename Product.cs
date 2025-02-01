//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{
//    class Product
//    {
//        private string productName;
//        private double price;
//        private static int totalProducts = 0;

//        // Constructor
//        public Product(string productName, double price)
//        {
//            this.productName = productName;
//            this.price = price;
//            totalProducts++;
//        }

//        // Method to Display Product Details
//        public void Display()
//        {
//            Console.WriteLine($"Product: {productName}, Price: ${price:F2}");
//        }

//        // Static Method to Get Total Products
//        public static int GetTotalProducts()
//        {
//            return totalProducts;
//        }
//    }

//    // Example Usage
//    class Program
//    {
//        static void Main()
//        {
//            Product product1 = new Product("Laptop", 899.99);
//            Product product2 = new Product("Smartphone", 679.99);

//            product1.Display();
//            product2.Display();

//            Console.WriteLine($"Total Products: {Product.GetTotalProducts()}");
//        }
//    }

//}
