using System;
namespace ConApi
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input radius of cyclinder");
			String r=Console.ReadLine();
			int radius=Convert.ToInt32(r);
			Console.WriteLine("input height of cyclinder");
			String h=Console.ReadLine();
			int height=Convert.ToInt32(h);
			float pi=3.14F;
			float ans=pi*radius*radius*height;
            Console.WriteLine("area of circle is:" +ans);
			Console.ReadLine();
        }
    }
}
