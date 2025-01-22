using System;


    class ques7
    {
	    static void Swap(ref int swapNum1,ref int swapNum2)
		{
		   int temp=swapNum1;
		    swapNum2=swapNum1;
		    swapNum1=temp;
		   Console.WriteLine("a after swapping:" +swapNum1);
		   Console.WriteLine("bafter swapping:" +swapNum2);
		}
        static void Main(string[] args)
        {
            Console.WriteLine("enter the a1");
			
			int swapNum1=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter the b1");
			
			int swapNum2=Convert.ToInt32(Console.ReadLine());
			
			Swap(ref swapNum1,ref swapNum2);
            Console.ReadLine();
        }
    }
