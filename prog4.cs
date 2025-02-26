

namespace json
{
    using System;
    using Newtonsoft.Json.Linq;

    class Prog4
    {
        static void Main()
        {
            // JSON object 1
            string json1 = @"{
            ""name"": ""Swati Kumari"",
            ""email"": ""Swati.Kumari@example.com""
        }";

            // JSON object 2
            string json2 = @"{
            ""age"": 30,
            ""address"": ""123 Main St""
        }";

            // Parse JSON strings into JObject
            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);

            // Merge obj2 into obj1
            obj1.Merge(obj2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union // E arrays are combined instead of replaced
            });

            // Output merged JSON
            Console.WriteLine(obj1.ToString());
        }
    }

}
