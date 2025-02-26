

namespace json
{
    using System;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    class Prog10
    {
        static void Main()
        {
            // JSON string containing multiple users
            string json = @"[
            { ""name"": ""John Doe"", ""age"": 30, ""email"": ""john@example.com"" },
            { ""name"": ""Jane Smith"", ""age"": 22, ""email"": ""jane@example.com"" },
            { ""name"": ""Mike Johnson"", ""age"": 28, ""email"": ""mike@example.com"" }
        ]";

            // Parse JSON into JArray
            JArray usersArray = JArray.Parse(json);

            // Filter users older than 25
            var filteredUsers = usersArray.Where(user => (int)user["age"] > 25);

            // Convert filtered users to JSON string
            string resultJson = JsonConvert.SerializeObject(filteredUsers, Formatting.Indented);

            // Output the filtered JSON
            Console.WriteLine(resultJson);
        }
    }

}
