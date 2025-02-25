

namespace CSV
{

    using System;
    using System.Collections.Generic;
    using System.IO;

    class DetectDuplicatesInCSV
    {
        static void Main()
        {
            string filePath = "students.csv"; // Change to your CSV file path
            HashSet<string> uniqueIds = new HashSet<string>();
            List<string> duplicateRecords = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string header = reader.ReadLine(); // Read and store header row
                    string line;
                    Console.WriteLine("Checking for duplicate records...\n");

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        if (data.Length < 1)
                            continue; // Skip invalid rows

                        string id = data[0].Trim(); // Extract ID column

                        if (!uniqueIds.Add(id))
                        {
                            duplicateRecords.Add(line); // Add duplicate record
                        }
                    }
                }

                // Print duplicates
                if (duplicateRecords.Count > 0)
                {
                    Console.WriteLine("Duplicate Records Found:");
                    foreach (var record in duplicateRecords)
                    {
                        Console.WriteLine(record);
                    }
                }
                else
                {
                    Console.WriteLine("No duplicate records found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
    }

}
