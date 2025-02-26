

namespace json
{

    using System;
    using System.IO;
    using Newtonsoft.Json.Linq;

    class Prog3
    {
        static void Main()
        {
            // Read the JSON file
            string jsonFilePath = "data.json";
            string jsonContent = File.ReadAllText(jsonFilePath);

            // Parse JSON
            JObject jsonObj = JObject.Parse(jsonContent);

            // Extract specific fields
            string name = jsonObj["name"]?.ToString();
            string email = jsonObj["email"]?.ToString();

            // Display extracted values
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
        }
    }

}
