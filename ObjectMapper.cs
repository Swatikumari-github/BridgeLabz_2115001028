

namespace AnnotationReflection
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, City: {City}");
        }
    }

    public class ObjectMapper
    {
        public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
        {
            // Create a new instance of the class
            T obj = new T();

            // Get all the properties of the class
            PropertyInfo[] propertyInfos = clazz.GetProperties();

            // Iterate over the properties and set their values from the dictionary
            foreach (var propertyInfo in propertyInfos)
            {
                if (properties.ContainsKey(propertyInfo.Name))
                {
                    // Get the value from the dictionary
                    object value = properties[propertyInfo.Name];

                    // Set the value of the property using Reflection
                    propertyInfo.SetValue(obj, Convert.ChangeType(value, propertyInfo.PropertyType));
                }
            }

            return obj;
        }
    }

    class ObjectMapper
    {
        static void Main()
        {
            // Create a dictionary with some property values
            Dictionary<string, object> properties = new Dictionary<string, object>
        {
            { "Name", "Alice" },
            { "Age", 30 },
            { "City", "New York" }
        };

            // Map the dictionary to a Person object
            Person person = ObjectMapper.ToObject<Person>(typeof(Person), properties);

            // Display the information of the person object
            person.DisplayInfo();
        }
    }

}
