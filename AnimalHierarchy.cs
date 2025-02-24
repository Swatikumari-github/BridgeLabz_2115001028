﻿namespace AnnotationReflection
{
    using System;

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks: Wooof! Wooof!");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal myDog = new Dog();
            myDog.MakeSound();  // Output: Dog barks: Woof! Woof!
        }
    }

}
