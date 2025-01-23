using System;
class ques11{
   static void SumUntilZero()
   {
       double total=0.0;
	   double userInput;
	   Console.WriteLine("enter the number to calculate the sum or enter 0 to stop");
	   while(true)
        {
            Console.Write("Enter a number: ");
            userInput = Convert.ToDouble(Console.ReadLine()); // Get user input

            if (userInput <= 0) // Only add if input is not 0
            {
               break;
            }
			 total += userInput;

        }
		
		Console.WriteLine("the total sum is:" +total);
		
	}
	static void Main(string [] args)
	{
	  
	  SumUntilZero();
	   Console.ReadLine();
	 }
}