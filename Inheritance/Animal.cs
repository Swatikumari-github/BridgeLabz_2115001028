//using System;

//class Program
//{
//    static void Main()
//    {
//        Animal[] animals =
//        {
//            new Dog("Rocky", 2),
//            new Cat("Kitty", 2),
//            new Bird("Coco", 1)
//        };

//        foreach (Animal animal in animals)
//        {
//            animal.MakeSound();
//        }
//    }
//}

//class Animal
//{
//    protected string Name;
//    protected int Age;

//    public Animal(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Some generic animal sound");
//    }
//}

//class Dog : Animal
//{
//    public Dog(string name, int age) : base(name, age) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{Name} is of {Age} years and barks");
//    }
//}

//class Cat : Animal
//{
//    public Cat(string name, int age) : base(name, age) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{Name} is of {Age} years and meows");
//    }
//}

//class Bird : Animal
//{
//    public Bird(string name, int age) : base(name, age) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{Name} is of {Age} years and chirps");
//    }
//}
