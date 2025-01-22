using System;


    class ques10
	{  
	   
	   
	   static void Main(String [] args)
	   {
	      
		 double cmToInch=0.393701;
		 int inchPerFoot = 12;
		 Console.Write("enter the height in cm");
		 double height=Convert.ToDouble(Console.ReadLine());
		 double totalInch=height*cmToInch;
		 int feet=(int)totalInch/inchPerFoot;
		 double inches=totalInch%inchPerFoot;
		 Console.WriteLine("Your height is approximately: " + feet + " feet and " + inches.ToString("F2") + " inches.");
         Console.ReadLine();
		  
		}
	}