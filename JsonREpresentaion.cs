
namespace AnnotationReflection
{

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    public class JsonREpresentation
    {
        public static string ToJson(object obj, int indentLevel = 0)
        {
            if (obj == null) return "null";

            Type type = obj.GetType();

            // Handle primitive types
            if (type == typeof(string))
                return $"\"{obj}\"";

            if (type.IsPrimitive || obj is decimal)
                return obj.ToString();

            // Handle lists and arrays
            if (obj is IEnumerable enumerable)
            {
                StringBuilder arrayJson = new StringBuilder();
                arrayJson.Append("[\n");

                foreach (var item in enumerable)
                {
                    arrayJson.Append(new string(' ', (indentLevel + 1) * 2));
                    arrayJson.Append(ToJson(item, indentLevel + 1));
                    arrayJson.Append(",\n");
                }

                if (arrayJson.Length > 2)
                    arrayJson.Remove(arrayJson.Length - 2, 2); // Remove last comma

                arrayJson.Append("\n");
                arrayJson.Append(new string(' ', indentLevel * 2) + "]");
                return arrayJson.ToString();
            }

            // Handle objects
            StringBuilder json = new StringBuilder();
            json.Append("{\n");

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            List<string> jsonElements = new List<string>();

            foreach (var field in fields)
            {
                object value = field.GetValue(obj);
                jsonElements.Add($"{new string(' ', (indentLevel + 1) * 2)}\"{field.Name}\": {ToJson(value, indentLevel + 1)}");
            }

            foreach (var property in properties)
            {
                if (property.CanRead)
                {
                    object value = property.GetValue(obj);
                    jsonElements.Add($"{new string(' ', (indentLevel + 1) * 2)}\"{property.Name}\": {ToJson(value, indentLevel + 1)}");
                }
            }

            json.Append(string.Join(",\n", jsonElements));
            json.Append("\n" + new string(' ', indentLevel * 2) + "}");

            return json.ToString();
        }
    }

    // Sample class for testing
    public class Person
    {
        public string Name;
        public int Age;
        public List<string> Hobbies { get; set; }

        public Person(string name, int age, List<string> hobbies)
        {
            Name = name;
            Age = age;
            Hobbies = hobbies;
        }
    }

    class Program
    {
        static void Main()
        {
            var person = new Person("Alice", 30, new List<string> { "Reading", "Traveling", "Music" });

            string jsonOutput = JsonConverter.ToJson(person);
            Console.WriteLine(jsonOutput);
        }
    }

}
