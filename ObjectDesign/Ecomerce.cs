//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObjectDesign
//{
//    using System;
//    using System.Collections.Generic;

//    class Product
//    {
//        public string Name { get; set; }
//        public decimal Price { get; set; }

//        public Product(string name, decimal price)
//        {
//            Name = name;
//            Price = price;
//        }

//        // View product details
//        public void ViewProduct()
//        {
//            Console.WriteLine($"Product: {Name}, Price: ${Price}");
//        }
//    }

//    class Order
//    {
//        public int OrderId { get; set; }
//        public DateTime OrderDate { get; set; }
//        public List<Product> Products { get; set; }
//        public string Status { get; set; }

//        public Order(int orderId, DateTime orderDate, string status)
//        {
//            OrderId = orderId;
//            OrderDate = orderDate;
//            Status = status;
//            Products = new List<Product>();
//        }

//        // Add product to the order
//        public void AddProduct(Product product)
//        {
//            Products.Add(product);
//        }

//        // View order details
//        public void ViewOrder()
//        {
//            Console.WriteLine($"Order ID: {OrderId}, Date: {OrderDate.ToShortDateString()}, Status: {Status}");
//            Console.WriteLine("Products in the order:");
//            foreach (var product in Products)
//            {
//                product.ViewProduct();
//            }
//        }

//        // Calculate the total cost of the order
//        public decimal CalculateTotal()
//        {
//            decimal total = 0;
//            foreach (var product in Products)
//            {
//                total += product.Price;
//            }
//            return total;
//        }
//    }

//    class Customer
//    {
//        public string Name { get; set; }
//        public string Email { get; set; }
//        public List<Order> Orders { get; set; }

//        public Customer(string name, string email)
//        {
//            Name = name;
//            Email = email;
//            Orders = new List<Order>();
//        }

//        // Place an order
//        public void PlaceOrder(Order order)
//        {
//            Orders.Add(order);
//        }

//        // View customer's order history
//        public void ViewOrders()
//        {
//            Console.WriteLine($"Orders placed by {Name}:");
//            foreach (var order in Orders)
//            {
//                order.ViewOrder();
//                Console.WriteLine($"Total: ${order.CalculateTotal():0.00}");
//            }
//        }
//    }

//    class Ecommerce
//    {
//        static void Main()
//        {
//            // Create products
//            Product product1 = new Product("Laptop", 999.99m);
//            Product product2 = new Product("Headphones", 199.99m);
//            Product product3 = new Product("Smartphone", 799.99m);

//            // Create customer
//            Console.Write("Enter customer name: ");
//            string customerName = Console.ReadLine();
//            Console.Write("Enter customer email: ");
//            string customerEmail = Console.ReadLine();
//            Customer customer = new Customer(customerName, customerEmail);

//            // Create an order
//            Order order1 = new Order(1, DateTime.Now, "Processing");
//            order1.AddProduct(product1);
//            order1.AddProduct(product2);

//            Order order2 = new Order(2, DateTime.Now, "Shipped");
//            order2.AddProduct(product3);

//            // Place orders for the customer
//            customer.PlaceOrder(order1);
//            customer.PlaceOrder(order2);

//            // View the customer's orders
//            customer.ViewOrders();
//        }
//    }

//}
