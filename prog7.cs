

namespace json
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    class Prog7
    {
        static void Main()
        {
            // JSON string containing multiple records
            string json = @"[
            { ""name"": ""Raj"", ""age"": 30, ""email"": ""Raj@example.com"" },
            { ""name"": ""Ram"", ""age"": 22, ""email"": ""Ram@example.com"" },
            { ""name"": ""Sohan"", ""age"": 28, ""email"": ""Sohan@example.com"" }
        ]";

            // Parse JSON into JArray
            JArray jsonArray = JArray.Parse(json);

            // Filter records where age > 25
            var filteredRecords = jsonArray.Where(obj => (int)obj["age"] > 25);

            // Convert filtered records to JSON
            string resultJson = JsonConvert.SerializeObject(filteredRecords, Formatting.Indented);

            // Output the filtered JSON
            Console.WriteLine(resultJson);
        }
    }

}
