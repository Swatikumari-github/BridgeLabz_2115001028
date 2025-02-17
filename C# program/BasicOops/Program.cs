using System;
namespace BasicOops
{
    class Program
    {
        static Program()
        {
            Console.WriteLine("HELLO");
        }
        Program()
        {
            Console.WriteLine("program");
        }
        public void m2()
        {
            Console.WriteLine("non static");
        }
        static int b = 10;
        public  static void m1()
        {
            
            Console.WriteLine("static");
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.m2();
            m1();
            Console.WriteLine(b);
        }
    }
}
