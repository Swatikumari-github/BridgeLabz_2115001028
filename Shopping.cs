using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{

    public class ShoppingCart
    {
        // Dictionary to store product prices by product name
        private Dictionary<string, double> productPrices = new Dictionary<string, double>();

        // List to simulate LinkedDictionary to maintain order of insertion
        private List<KeyValuePair<string, double>> orderedProducts = new List<KeyValuePair<string, double>>();

        // SortedDictionary to store products sorted by price
        private SortedDictionary<string, double> sortedProductsByPrice = new SortedDictionary<string, double>(
            new Comparison<KeyValuePair<string, double>>((x, y) => x.Value.CompareTo(y.Value))
        );

        // Add a product to the shopping cart
        public void AddProduct(string productName, double price)
        {
            if (!productPrices.ContainsKey(productName))
            {
                productPrices[productName] = price;
                orderedProducts.Add(new KeyValuePair<string, double>(productName, price));
                sortedProductsByPrice[productName] = price;
            }
            else
            {
                Console.WriteLine($"Product {productName} already exists in the cart.");
            }
        }

        // Remove a product from the shopping cart
        public void RemoveProduct(string productName)
        {
            if (productPrices.ContainsKey(productName))
            {
                productPrices.Remove(productName);
                orderedProducts.RemoveAll(p => p.Key == productName);
                sortedProductsByPrice.Remove(productName);
            }
            else
            {
                Console.WriteLine($"Product {productName} not found in the cart.");
            }
        }

        // Get all products in the order they were added (simulating LinkedDictionary)
        public IEnumerable<KeyValuePair<string, double>> GetProductsInInsertionOrder()
        {
            return orderedProducts;
        }

        // Get all products sorted by price (SortedDictionary)
        public IEnumerable<KeyValuePair<string, double>> GetSortedProductsByPrice()
        {
            return sortedProductsByPrice;
        }

        // Get total price of all items in the cart
        public double GetTotalPrice()
        {
            return productPrices.Values.Sum();
        }
    }

    class Shopping
    {
        static void Main()
        {
            var shoppingCart = new ShoppingCart();

            // Add some products to the cart
            shoppingCart.AddProduct("Laptop", 1200.00);
            shoppingCart.AddProduct("Headphones", 150.50);
            shoppingCart.AddProduct("Smartphone", 800.00);
            shoppingCart.AddProduct("Keyboard", 75.00);

            // Display all products in the order they were inserted
            Console.WriteLine("Products in Insertion Order (LinkedDictionary Style):");
            foreach (var product in shoppingCart.GetProductsInInsertionOrder())
            {
                Console.WriteLine($"{product.Key}: ${product.Value}");
            }

            // Display all products sorted by price
            Console.WriteLine("\nProducts Sorted by Price:");
            foreach (var product in shoppingCart.GetSortedProductsByPrice())
            {
                Console.WriteLine($"{product.Key}: ${product.Value}");
            }

            // Get the total price of all items in the cart
            Console.WriteLine($"\nTotal Price: ${shoppingCart.GetTotalPrice()}");

            // Remove a product from the cart
            shoppingCart.RemoveProduct("Headphones");
            Console.WriteLine("\nAfter Removing Headphones:");

            // Display products after removal
            foreach (var product in shoppingCart.GetProductsInInsertionOrder())
            {
                Console.WriteLine($"{product.Key}: ${product.Value}");
            }
        }
    }

}
