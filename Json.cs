

namespace AnnotationReflection
{
    using System;
    using System.Reflection;
    using System.Text;

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    public class JsonConverter
    {
        public static string ToJson(object obj)
        {
            // Get the type of the object
            Type objType = obj.GetType();

            // Create a StringBuilder to construct the JSON string
            StringBuilder jsonString = new StringBuilder();

            // Start the JSON object
            jsonString.Append("{");

            // Get the fields or properties of the object
            PropertyInfo[] properties = objType.GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                // Get the property name and value
                string propertyName = properties[i].Name;
                object propertyValue = properties[i].GetValue(obj);

                // Append the property to the JSON string
                jsonString.Append($"\"{propertyName}\": \"{propertyValue}\"");

                // If it's not the last property, add a comma for separation
                if (i < properties.Length - 1)
                {
                    jsonString.Append(", ");
                }
            }

            // Close the JSON object
            jsonString.Append("}");

            return jsonString.ToString();
        }
    }

    class Json
    {
        static void Main()
        {
            // Create an instance of the Person class
            Person person = new Person
            {
                Name = "Alice",
                Age = 30,
                City = "New York"
            };

            // Convert the object to a JSON-like string
            string jsonRepresentation = JsonConverter.ToJson(person);

            // Print the JSON-like string
            Console.WriteLine(jsonRepresentation);
        }
    }

}
