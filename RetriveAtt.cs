

namespace AnnotationReflection
{
    using System;
    using System.Reflection;

    // Define a custom attribute 'Author'
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }

        // Constructor that accepts an author name
        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    // Apply the 'Author' attribute to a class
    [Author("John Doe")]
    public class SampleClass1
    {
        public void Display()
        {
            Console.WriteLine("This is a sample class.");
        }
    }

    class RetriveAtt
    {
        static void Main()
        {
            // Get the Type object for the SampleClass
            Type sampleType = typeof(SampleClass);

            // Retrieve the 'Author' attribute applied to the class
            AuthorAttribute authorAttribute = (AuthorAttribute)Attribute.GetCustomAttribute(sampleType, typeof(AuthorAttribute));

            if (authorAttribute != null)
            {
                // Display the value of the 'Author' attribute
                Console.WriteLine($"Author: {authorAttribute.Name}");
            }
            else
            {
                Console.WriteLine("Author attribute not found.");
            }
        }
    }

}
