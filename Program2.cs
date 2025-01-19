using System;
namespace ConApi
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input first number");
			String n=Console.ReadLine();
			int num1=Convert.ToInt32(n);
			Console.WriteLine("input second number");
			String n1=Console.ReadLine();
			int num2=Convert.ToInt32(n1);
			int ans=num1+num2;
			Console.WriteLine("Answer after adding:" +ans);
			
            Console.ReadLine();
        }
    }
}
