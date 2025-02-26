

namespace json
{
    using System;
    using Newtonsoft.Json.Linq;

    class Prog5
    {
        static void Main()
        {
            // First JSON object
            string json1 = @"{
            ""name"": ""John Doe"",
            ""email"": ""john.doe@example.com"",
            ""skills"": [""C#"", ""SQL""]
        }";

            // Second JSON object
            string json2 = @"{
            ""age"": 30,
            ""address"": ""123 Main St"",
            ""skills"": [""Python"", ""JavaScript""]
        }";

            // Parse JSON strings into JObject
            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);

            // Merge obj2 into obj1
            obj1.Merge(obj2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union // Ensures arrays are combined instead of replaced
            });

            // Output merged JSON
            Console.WriteLine(obj1.ToString());
        }
    }


}
