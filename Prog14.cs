

namespace json
{
    using System;
    using System.Collections.Generic;
    using System.Formats.Asn1;
    using System.Globalization;
    using System.IO;
    using CsvHelper;
    using Newtonsoft.Json;

    class Prog14
    {
        static void Main()
        {
            // Define the file path for the CSV
            string csvFilePath = "data.csv"; // Replace with your CSV file path
// convert to a list of objects
            var records = ReadCsv(csvFilePath);

            // Convert the list of objects to JSON
            string json = JsonConvert.SerializeObject(records, Formatting.Indented);

            // Output the JSON
            Console.WriteLine(json);
        }

        // Function to read CSV data and return a list of dynamic objects
        static List<dynamic> ReadCsv(string filePath)
        {
            var records = new List<dynamic>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Read all records in CSV
                var csvRecords = csv.GetRecords<dynamic>();

                foreach (var record in csvRecords)
                {
                    records.Add(record);
                }
            }

            return records;
        }
    }

}
