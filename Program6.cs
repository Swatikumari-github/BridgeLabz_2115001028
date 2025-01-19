using System;
namespace ConApi
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input principal");
			String p=Console.ReadLine();
			int principal=Convert.ToInt32(p);
			Console.WriteLine("input rate");
			String r=Console.ReadLine();
			float rate=float.Parse(r);
			Console.WriteLine("input time");
			String t=Console.ReadLine();
			float time=float.Parse(t);
			float SI=(principal*rate*time)/100;
            Console.WriteLine("SI is:" +SI);
			Console.ReadLine();
        }
    }
}
