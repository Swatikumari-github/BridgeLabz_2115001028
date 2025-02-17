//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Demo
//{


//    class Class1
//    {
//        static void Main()
//        {
//            Console.WriteLine("Using return:");
//            ReturnExample();

//            Console.WriteLine("\nUsing System.Environment.Exit():");
//            ExitExample();
//        }

//        static void ReturnExample()
//        {
//            Console.WriteLine("Before return statement");
//            return; // ❌ Only exits this function, not the whole program
//            Console.WriteLine("This will execute in Main()");
//        }

//        static void ExitExample()
//        {
//            Console.WriteLine("Before exit");
//            System.Environment.Exit(0); // ✅ Entire program terminates
//            Console.WriteLine("This will never run!"); // ❌ Never executes
//        }
//    }

//}
