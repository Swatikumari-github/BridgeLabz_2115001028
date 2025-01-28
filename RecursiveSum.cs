using System;
using System.Linq;
class ques2

{
     static int CalculateRecursiveSum(int n)
    {
        if (n == 1) // Base case
        {
            return 1;
        }
        return n + CalculateRecursiveSum(n - 1); 
    }

    static int CalculateFormulaSum(int n)
    {
        return n * (n + 1) / 2; 
    }
	
    
	static void Main(string [] args)
	{
		
        Console.Write("Enter a natural number: ");
       int n=Convert.ToInt32(Console.ReadLine());
	   if(n<=0)
	   {
		   Console.WriteLine("Please input a valid number");
	   }

        // Calculate sum using recursion
        int recursiveSum = CalculateRecursiveSum(n);

        // Calculate sum using formula
        int formulaSum = CalculateFormulaSum(n);

        // Compare the results and display
        Console.WriteLine("Sum using recursion: "+recursiveSum);
        Console.WriteLine("Sum using formula: " +formulaSum);

        if (recursiveSum == formulaSum)
        {
            Console.WriteLine("The results from both computations match and are correct.");
        }
        else
        {
            Console.WriteLine("The results do not match. There might be an error in the computation.");
        }
    }

	
}