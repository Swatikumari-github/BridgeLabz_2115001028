

namespace json
{
    using System;
    using System.IO;
    using Newtonsoft.Json.Linq;

    class Prog12
    {
        static void Main()
        {
            // Load JSON from two files
            string jsonFile1 = "file1.json"; // Replace with your file path
            string jsonFile2 = "file2.json"; // Replace with your file path

            string json1 = File.ReadAllText(jsonFile1);
            string json2 = File.ReadAllText(jsonFile2);

            // Parse JSON strings into JObjects
            JObject jsonObject1 = JObject.Parse(json1);
            JObject jsonObject2 = JObject.Parse(json2);

            // Merge the second JSON into the first
            jsonObject1.Merge(jsonObject2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union // Options to handle arrays
            });

            // Output the merged JSON object
            string mergedJson = jsonObject1.ToString();
            Console.WriteLine(mergedJson);
        }
    }

}
