

namespace json
{
    using System;
    using System.IO;
    using Newtonsoft.Json.Linq;

    class Prog8
    {
        static void Main()
        {
            // Read the JSON file
            string filePath = "data.json"; // Replace with your file path
            string jsonContent = File.ReadAllText(filePath);

            // Parse JSON into JObject
            JObject jsonObj = JObject.Parse(jsonContent);

            // Recursively print all keys and values
            PrintJson(jsonObj);
        }

        static void PrintJson(JObject jsonObj)
        {
            foreach (var property in jsonObj.Properties())
            {
                if (property.Value.Type == JTokenType.Object)
                {
                    Console.WriteLine($"Key: {property.Name}");
                    PrintJson((JObject)property.Value); // Recursive call for nested objects
                }
                else
                {
                    Console.WriteLine($"Key: {property.Name}, Value: {property.Value}");
                }
            }
        }
    }


}
