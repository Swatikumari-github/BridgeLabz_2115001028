

namespace CSV
{
    using System;
    using System.IO;

    class Prog3
    {
        static void Main()
        {
            // Path to your CSV file
            string filePath = "employees.csv";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(filePath);

                // Count the number of records (excluding the header row)
                int recordCount = lines.Length - 1;  // Subtracting 1 to exclude the header row

                Console.WriteLine("Number of records (excluding header): " + recordCount);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }


}
