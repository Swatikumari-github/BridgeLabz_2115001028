

namespace CSV
{
    using System;
    using System.IO;

    class Prog6
    {
        static void Main()
        {
            // Path to the original CSV file and the new CSV file
            string originalFilePath = "employees.csv";
            string newFilePath = "updated_employees.csv";

            // Check if the original file exists
            if (File.Exists(originalFilePath))
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(originalFilePath);

                // Open a new file to write the updated records
                using (StreamWriter writer = new StreamWriter(newFilePath))
                {
                    // Write the header row to the new file
                    writer.WriteLine(lines[0]);

                    // Process each record starting from the second line
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        string[] values = line.Split(',');

                        // Assuming CSV format: ID, Name, Department, Salary
                        string employeeName = values[1];
                        string department = values[2];
                        double salary = double.Parse(values[3]);  // Convert salary to a double

                        // If the employee is from the IT department, increase their salary by 10%
                        if (department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                        {
                            salary *= 1.10;  // Increase salary by 10%
                        }

                        // Write the updated record to the new CSV file
                        writer.WriteLine($"{values[0]},{employeeName},{department},{salary:F2}");
                    }
                }

                Console.WriteLine("Salary updates have been applied and saved to the new file.");
            }
            else
            {
                Console.WriteLine("Original CSV file not found.");
            }
        }
    }

}
