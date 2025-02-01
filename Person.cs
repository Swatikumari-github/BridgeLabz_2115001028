//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{
//    class Person
//    {
//        private string name;
//        private int age;

//        // Parameterized Constructor
//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }

//        // Copy Constructor
//        public Person(Person other)
//        {
//            this.name = other.name;
//            this.age = other.age;
//        }

//        public void Display()
//        {
//            Console.WriteLine($"Name: {name}, Age: {age}");
//        }
//    }

//    // Example Usage
//    class Program
//    {
//        static void Main()
//        {
//            Person person1 = new Person("Alice", 30);  // Using parameterized constructor
//            Person person2 = new Person(person1);  // Using copy constructor

//            person1.Display();
//            person2.Display();
//        }
//    }

//}
