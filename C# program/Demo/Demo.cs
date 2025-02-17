using System;
namespace Demo
{
    class Demo
    {
        static Demo()
        {
            Console.WriteLine("HELLO");
        }
        Demo()
        {
            Console.WriteLine("program");
        }
        public void m2()
        {
            Console.WriteLine("non static");
        }
        static int b = 10;
        public static void m1()
        {

            Console.WriteLine("static");
        }
        public static void Main(string[] args)
        {
            Demo p = new Demo();
            p.m2();
            m1();
            Console.WriteLine(b);
        }
    }
}
