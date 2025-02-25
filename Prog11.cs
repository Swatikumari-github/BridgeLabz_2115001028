

namespace CSV
{
    using System;
    using System.IO;

    class LargeCSVReader
    {
        static void Main()
        {
            string filePath = "large_data.csv"; // Change to your actual file path
            int batchSize = 100; // Process 100 lines at a time
            int totalRecordsProcessed = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    int batchCount = 0;

                    reader.ReadLine(); // Skip header row if present

                    while ((line = reader.ReadLine()) != null)
                    {
                        // Process the line (You can replace this with actual logic)
                        batchCount++;
                        totalRecordsProcessed++;

                        if (batchCount == batchSize)
                        {
                            Console.WriteLine($"Processed {totalRecordsProcessed} records...");
                            batchCount = 0; // Reset batch count
                        }
                    }

                    // Print final count if remaining lines are less than batchSize
                    if (batchCount > 0)
                    {
                        Console.WriteLine($"Processed {totalRecordsProcessed} records...");
                    }
                }

                Console.WriteLine("Finished processing all records.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
    }

}
