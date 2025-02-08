using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{



    class SchoolSystem
    {
        static void Main()
        {
            Person[] people =
            {
            new Teacher("Mr. Raj", 30, "Mathematics"),
            new Student("Shashank", 15, 10),
            new Staff("Aishwarya", 25, "Administration")
        };

            foreach (Person person in people)
            {
                person.DisplayInfo();
                if (person is Teacher teacher)
                {
                    teacher.DisplayRole();
                }
                else if (person is Student student)
                {
                    student.DisplayRole();
                }
                else if (person is Staff staff)
                {
                    staff.DisplayRole();
                }
                Console.WriteLine();
            }
        }
    }

    class Person
    {
        protected string Name;
        protected int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Teacher : Person
    {
        private string Subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public void DisplayRole()
        {
            Console.WriteLine($"{Name} is a Teacher who teaches {Subject}.");
        }
    }

    class Student : Person
    {
        private int Grade;

        public Student(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
        }

        public void DisplayRole()
        {
            Console.WriteLine($"{Name} is a Student in Grade {Grade}.");
        }
    }

    class Staff : Person
    {
        private string Department;

        public Staff(string name, int age, string department) : base(name, age)
        {
            Department = department;
        }

        public void DisplayRole()
        {
            Console.WriteLine($"{Name} is a Staff member in the {Department} department.");
        }
    }


}
