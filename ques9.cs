using System;


    class ques9
	{  
	   
	   
	   static void Main(String [] args)
	   {
	     Console.WriteLine("enter the fee"); 
		 double fee=Convert.ToDouble(Console.ReadLine());
		 
		 Console.WriteLine("enter the discount");
		 double discountPercent=Convert.ToDouble(Console.ReadLine());
		
		
		double discount = (discountPercent / 100) * fee;
		double discountedPrice = fee - discount;
		Console.WriteLine("The discounted amount is: INR " + discount);
        Console.WriteLine("The discounted price the student will pay is: INR " + discountedPrice);

		 
		 Console.ReadLine();
		  
		}
	}
