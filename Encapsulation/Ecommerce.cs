//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Encapsulation
//{
    

//    // Abstract class Product
//    abstract class Product
//    {
//        private int productId;
//        private string name;
//        private double price;

//        public int ProductId { get => productId; set => productId = value; }
//        public string Name { get => name; set => name = value; }
//        public double Price { get => price; set => price = value; }

//        protected Product(int id, string name, double price)
//        {
//            ProductId = id;
//            Name = name;
//            Price = price;
//        }

//        public abstract double CalculateDiscount();

//        public virtual double GetFinalPrice()
//        {
//            return Price - CalculateDiscount();
//        }

//        public void DisplayDetails()
//        {
//            Console.WriteLine($"ID: {ProductId}, Name: {Name}, Final Price: {GetFinalPrice():C}");
//        }
//    }

//    interface ITaxable
//    {
//        double CalculateTax();
//        string GetTaxDetails();
//    }

//    class Electronics : Product, ITaxable
//    {
//        public Electronics(int id, string name, double price) : base(id, name, price) { }

//        public override double CalculateDiscount()
//        {
//            return Price * 0.10; // 10% discount
//        }

//        public double CalculateTax()
//        {
//            return Price * 0.15; // 15% tax
//        }

//        public string GetTaxDetails()
//        {
//            return "Tax Rate: 15%";
//        }

//        public override double GetFinalPrice()
//        {
//            return Price + CalculateTax() - CalculateDiscount();
//        }
//    }

//    class Clothing : Product
//    {
//        public Clothing(int id, string name, double price) : base(id, name, price) { }

//        public override double CalculateDiscount()
//        {
//            return Price * 0.20; // 20% discount
//        }
//    }

//    class Groceries : Product
//    {
//        public Groceries(int id, string name, double price) : base(id, name, price) { }

//        public override double CalculateDiscount()
//        {
//            return Price * 0.05; // 5% discount
//        }
//    }

//    class Ecommerce
//    {
//        static void Main()
//        {
//            List<Product> products = new List<Product>();

//            Console.Write("Enter the number of products: ");
//            int numProducts = int.Parse(Console.ReadLine());

//            for (int i = 0; i < numProducts; i++)
//            {
//                Console.Write("Enter Product Type (Electronics/Clothing/Groceries): ");
//                string type = Console.ReadLine();

//                Console.Write("Enter Product ID: ");
//                int id = int.Parse(Console.ReadLine());

//                Console.Write("Enter Product Name: ");
//                string name = Console.ReadLine();

//                Console.Write("Enter Product Price: ");
//                double price = double.Parse(Console.ReadLine());

//                if (type.ToLower() == "electronics")
//                {
//                    products.Add(new Electronics(id, name, price));
//                }
//                else if (type.ToLower() == "clothing")
//                {
//                    products.Add(new Clothing(id, name, price));
//                }
//                else if (type.ToLower() == "groceries")
//                {
//                    products.Add(new Groceries(id, name, price));
//                }
//                else
//                {
//                    Console.WriteLine("Invalid product type!");
//                }
//            }

//            Console.WriteLine("\nProduct Details:");
//            foreach (Product product in products)
//            {
//                product.DisplayDetails();
//            }
//        }
//    }

//}
