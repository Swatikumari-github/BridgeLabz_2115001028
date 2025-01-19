using System;
namespace ConApi
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input length");
			String l=Console.ReadLine();
			int length=Convert.ToInt32(l);
			Console.WriteLine("input width");
			String w=Console.ReadLine();
            int width=Convert.ToInt32(w); 
			int perimeter=2*(length+width);
            Console.WriteLine("perimeter of rectangle is:" +perimeter);
			Console.ReadLine();
        }
    }
}
