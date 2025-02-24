using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace AnnotationReflection
{
    

    // Define the JsonField attribute
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class JsonFieldAttribute : Attribute
    {
        public string Name { get; }

        public JsonFieldAttribute(string name)
        {
            Name = name;
        }
    }

    // User class with fields marked with the JsonField attribute
    class User
    {
        [JsonField("user_name")]  // Custom JSON key for this field
        public string Username;

        [JsonField("user_age")]   // Custom JSON key for this field
        public int Age;

        public string Email;

        public User(string username, int age, string email)
        {
            Username = username;
            Age = age;
            Email = email;
        }
    }

    // JSON Serializer class
    class JsonSerializer
    {
        public static string SerializeToJson(object obj)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("{");

            // Get all fields and properties of the object
            FieldInfo[] fields = obj.GetType().GetFields();
            PropertyInfo[] properties = obj.GetType().GetProperties();

            List<string> keyValuePairs = new List<string>();

            // Serialize fields
            foreach (var field in fields)
            {
                var jsonFieldAttribute = (JsonFieldAttribute)Attribute.GetCustomAttribute(field, typeof(JsonFieldAttribute));
                if (jsonFieldAttribute != null)
                {
                    string jsonKey = jsonFieldAttribute.Name;
                    string value = field.GetValue(obj)?.ToString();
                    keyValuePairs.Add($"\"{jsonKey}\": \"{value}\"");
                }
                else
                {
                    // If no JsonField attribute, just use the field name
                    keyValuePairs.Add($"\"{field.Name}\": \"{field.GetValue(obj)}\"");
                }
            }

            // Serialize properties
            foreach (var property in properties)
            {
                var jsonFieldAttribute = (JsonFieldAttribute)Attribute.GetCustomAttribute(property, typeof(JsonFieldAttribute));
                if (jsonFieldAttribute != null)
                {
                    string jsonKey = jsonFieldAttribute.Name;
                    string value = property.GetValue(obj)?.ToString();
                    keyValuePairs.Add($"\"{jsonKey}\": \"{value}\"");
                }
                else
                {
                    // If no JsonField attribute, just use the property name
                    keyValuePairs.Add($"\"{property.Name}\": \"{property.GetValue(obj)}\"");
                }
            }

            // Combine all key-value pairs
            jsonBuilder.Append(string.Join(", ", keyValuePairs));
            jsonBuilder.Append("}");

            return jsonBuilder.ToString();
        }
    }

    class Serialization
    {
        static void Main()
        {
            // Create a new User object
            User user = new User("JohnDoe", 25, "johndoe@example.com");

            // Serialize the user object to JSON
            string json = JsonSerializer.SerializeToJson(user);

            // Print the serialized JSON string
            Console.WriteLine(json);
        }
    }

}
