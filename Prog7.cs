

namespace CSV
{

    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    class Prog7
    {
        static void Main()
        {
            // Path to the CSV file
            string filePath = "employees.csv";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(filePath);

                // Skip the header and store employee records in a list
                List<string[]> employees = new List<string[]>();

                for (int i = 1; i < lines.Length; i++)
                {
                    employees.Add(lines[i].Split(',')); // Split each line into columns
                }

                // Sort the list based on Salary (descending order)
                var sortedEmployees = employees
                    .OrderByDescending(emp => double.Parse(emp[3])) // Parsing Salary as double
                    .Take(5) // Get top 5 highest-paid employees
                    .ToList();

                // Print the top 5 highest-paid employees
                Console.WriteLine("Top 5 Highest Paid Employees:");
                Console.WriteLine("ID\tName\tDepartment\tSalary");

                foreach (var emp in sortedEmployees)
                {
                    Console.WriteLine($"{emp[0]}\t{emp[1]}\t{emp[2]}\t{emp[3]}");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }

}
