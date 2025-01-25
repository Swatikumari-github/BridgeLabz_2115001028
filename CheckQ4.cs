using System;
class Program{
   static void Check()
   {
      double []numbers=new double[10];
	  double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter up to 10 numbers (enter 0 or a negative number to stop):");
		while(true)
		{
		  double input;
		  if (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; // Prompt user again for valid input
            }
			  if (input <= 0 || index == 10)
            {
                break; // Exit the loop if input is 0, negative, or array is full
            }
			  numbers[index] = input;
            index++;
        }
   for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }
		Console.WriteLine(total);
		  
	}
	static void Main(string [] args)
	{
	  
	 Check();
	  }
	 }