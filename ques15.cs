using System;

class ques15
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the unit price of item");
		double unitPrice=Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("enter the quantity to be bought");
		double quantity=Convert.ToDouble(Console.ReadLine());
		double totalPrice=unitPrice*quantity;
		Console.WriteLine("the total price of the item:" +totalPrice);		

        Console.ReadLine(); 
    }
}