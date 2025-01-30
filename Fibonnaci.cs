using System;

class Fibonacci
{
   static void GenerateFibonacci(int last)
    {
        if (last <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        long first = 0, second = 1;
        Console.Write("Fibonacci Sequence: " + first);
        
        for (int i = 1; i < last; i++)
        {
            Console.Write(", " + second);
            long next = first + second;
            first = second;
            second = next;
        }
        Console.WriteLine();
    }
  static void Main(string [] args)
 {
     Console.WriteLine("Enter the term upto which we have to find fibonacci:");
	 int last=Convert.ToInt32(Console.ReadLine());
	 
        GenerateFibonacci(last);
		Console.ReadLine();
       
 }
 }