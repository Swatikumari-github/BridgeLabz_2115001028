

namespace json
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Schema;
    using Newtonsoft.Json.Linq;

    class Prog11
    {
        static void Main()
        {
            // JSON Schema for validating email
            string schemaJson = @"
        {
          ""$schema"": ""http://json-schema.org/draft-07/schema#"",
          ""type"": ""object"",
          ""properties"": {
            ""email"": {
              ""type"": ""string"",
              ""format"": ""email""
            }
          },
          ""required"": [""email""]
        }";

            // The JSON data to validate
            string jsonData = @"{
          ""email"": ""john.doe@example.com""
        }";

            // Parse the JSON Schema
            JSchema schema = JSchema.Parse(schemaJson);

            // Parse the JSON data
            JObject jsonObject = JObject.Parse(jsonData);

            // Validate the JSON data against the schema
            bool isValid = jsonObject.IsValid(schema);

            // Output the result
            if (isValid)
            {
                Console.WriteLine("The email is valid.");
            }
            else
            {
                Console.WriteLine("The email is invalid.");
            }
        }
    }

}
