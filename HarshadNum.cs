using System;

class counter
 
{
     static void Counter(int number)
	 {
	    int sum=0;
		int originalNum=number;
		 while (number > 0)
        {
            // Get the last digit
            int digit = number % 10;

            // Add the digit to the sum
            sum += digit;

            // Remove the last digit
            number /= 10;
        }

    if(originalNum%sum==0){
	Console.WriteLine("the given number is a harshad number");
}
else{
Console.WriteLine("the given number is not a harshad number");
}
  
	 }
    static void Main()
    {
        Console.WriteLine("enter the number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
	    Counter(number);
		Console.ReadLine();
    }
}