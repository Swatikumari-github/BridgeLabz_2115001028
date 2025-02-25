

namespace CSV
{
    using System;
    using System.IO;

    class Prog5
    {
        static void Main()
        {
            // Path to your CSV file
            string filePath = "employees.csv";

            // Ask the user for the employee name to search
            Console.Write("Enter the employee name to search: ");
            string searchName = Console.ReadLine();

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(filePath);

                // Flag to check if the employee was found
                bool found = false;

                // Skip the header row and process each record
                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] values = line.Split(',');

                    // Assuming CSV format: ID, Name, Department, Salary
                    string employeeName = values[1];

                    // Check if the employee name matches the search query
                    if (employeeName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        string department = values[2];
                        string salary = values[3];

                        // Print the employee's department and salary
                        Console.WriteLine($"Employee Found: {employeeName}");
                        Console.WriteLine($"Department: {department}");
                        Console.WriteLine($"Salary: {salary}");
                        found = true;
                        break; // Exit the loop once the employee is found
                    }
                }

                // If the employee was not found, print a message
                if (!found)
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }


}
