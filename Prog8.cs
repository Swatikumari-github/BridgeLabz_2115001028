using System;


namespace ExceptionHandle
{


    class Prog8
    {
        static void Method1()
        {
            throw new ArithmeticException("Attempted to divide by zero.");
        }

        static void Method2()
        {
            Method1();
        }

        static void Main()
        {
            try
            {
                Method2();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Handled exception in Main");
            }
        }
    }

}
