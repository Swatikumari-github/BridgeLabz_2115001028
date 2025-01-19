using System;
namespace ConApi
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input temp in celcius");
			String C=Console.ReadLine();
			int C1=Convert.ToInt32(C);
			float F=(C1*9.0f/5)+32;
			Console.WriteLine("Temperature in fahrenheit:" +F);
			
            Console.ReadLine();
        }
    }
}
