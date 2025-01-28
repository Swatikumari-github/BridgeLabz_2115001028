using System;
class ques7{
   static void SpringSeason(int month,int day)
   {
         bool isSpring = (month == 3 && day >= 20 && day <= 31) ||  
                        (month == 4 && day >= 1 && day <= 30) ||   
                        (month == 5 && day >= 1 && day <= 31) ||   
                        (month == 6 && day >= 1 && day <= 20);  
		if(isSpring){
		Console.WriteLine("it's a spring season");
		}
		else{
		Console.WriteLine("it is not a spring season");
		}
	}
	static void Main(string [] args)
	{
	   Console.WriteLine("enter the month:");
	   int month=Convert.ToInt32(Console.ReadLine());
	   Console.WriteLine("enter the day:");
	   int day=Convert.ToInt32(Console.ReadLine());
	   SpringSeason(month,day);
	   Console.ReadLine();
	 }
}