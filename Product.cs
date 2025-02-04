//using System;

//class Product
//{
//    public static double Discount = 10.0;
//    public readonly int ProductID;
//    private string ProductName;
//    private double Price;
//    private int Quantity;

//    public Product(string productName, int productID, double price, int quantity)
//    {
//        this.ProductName = productName;
//        this.ProductID = productID;
//        this.Price = price;
//        this.Quantity = quantity;
//    }

//    public static void UpdateDiscount(double newDiscount)
//    {
//        Discount = newDiscount;
//    }

//    public void DisplayDetails()
//    {
//        if (this is Product)
//        {
//            double totalPrice = Price * Quantity;
//            double discountAmount = (Discount / 100) * totalPrice;
//            double finalPrice = totalPrice - discountAmount;

//            Console.WriteLine("Product Name: " + this.ProductName);
//            Console.WriteLine("Product ID: " + this.ProductID);
//            Console.WriteLine("Price: " + this.Price);
//            Console.WriteLine("Quantity: " + this.Quantity);
//            Console.WriteLine("Discount: " + Discount + "%");
//            Console.WriteLine("Total Price before Discount: " + totalPrice);
//            Console.WriteLine("Discount Amount: " + discountAmount);
//            Console.WriteLine("Final Price after Discount: " + finalPrice);
//        }
//    }

//    static void Main(string[] args)
//    {


//        Console.Write("Enter number of products: ");
//        int productCount = Convert.ToInt32(Console.ReadLine());

//        Product[] products = new Product[productCount];

//        for (int i = 0; i < productCount; i++)
//        {
//            Console.WriteLine("\nEnter details ofProduct " + (i + 1));

//            Console.Write("Enter Product Name: ");
//            string name = Console.ReadLine();

//            Console.Write("Enter Product ID: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter Price: ");
//            double price = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Enter Quantity: ");
//            int quantity = Convert.ToInt32(Console.ReadLine());

//            products[i] = new Product(name, id, price, quantity);
//        }

//        Console.Write("\nEnter new discount percentage: ");
//        double newDiscount = Convert.ToDouble(Console.ReadLine());
//        Product.UpdateDiscount(newDiscount);

//        Console.WriteLine("\nProduct after updated discount:");

//        foreach (Product product in products)
//        {
//            product.DisplayDetails();
//            Console.WriteLine();
//        }
//    }
}