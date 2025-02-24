using System;
using System.Reflection;

namespace AnnotationReflection
{
    

    public class Person
    {
        private int age;

        // Constructor
        public Person(int age)
        {
            this.age = age;
        }
    }

    class PrivateField
    {
        static void Main()
        {
            // Create an instance of the Person class
            Person person = new Person(25);

            // Use Reflection to get the private field 'age'
            Type personType = typeof(Person);
            FieldInfo fieldInfo = personType.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            if (fieldInfo != null)
            {
                // Retrieve the value of the private field 'age'
                Console.WriteLine("Initial Age: " + fieldInfo.GetValue(person));

                // Modify the value of the private field 'age'
                fieldInfo.SetValue(person, 30);

                // Retrieve the modified value of the private field 'age'
                Console.WriteLine("Updated Age: " + fieldInfo.GetValue(person));
            }
            else
            {
                Console.WriteLine("Field 'age' not found.");
            }
        }
    }

}
