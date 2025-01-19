using System;
namespace ConApi
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input radius of circle");
			String r=Console.ReadLine();
			int radius=Convert.ToInt32(r);
			float pi=3.14F;
			float ans=pi*radius*radius;
            Console.WriteLine("area of circle is:" +ans);
			Console.ReadLine();
        }
    }
}
