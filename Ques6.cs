using System;


    class ques6
	{  
	   
	   
	   static void Main(String [] args)
	   {
	      
		 double fee=125000;
		 double discountPercent=10;
		
		double discount = (discountPercent / 100) * fee;
		double discountedPrice = fee - discount;
		Console.WriteLine("The discounted amount is: INR " + discount);
        Console.WriteLine("The discounted price the student will pay is: INR " + discountedPrice);

		 
		 Console.ReadLine();
		  
		}
	}
