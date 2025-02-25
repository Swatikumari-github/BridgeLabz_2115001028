

namespace CSV
{
    using System;
    using System.IO;

    class Prog4
    {
        static void Main()
        {
            // Path to the CSV file
            string filePath = "students.csv";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(filePath);

                // Skip the header row and process each record
                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] values = line.Split(',');

                    // Assuming CSV format: ID, Name, Age, Marks
                    string studentId = values[0];
                    string name = values[1];
                    string age = values[2];
                    int marks = int.Parse(values[3]);  // Convert marks to an integer

                    // Check if the student's marks are greater than 80
                    if (marks > 80)
                    {
                        // Print the qualifying records
                        Console.WriteLine("Student ID: " + studentId);
                        Console.WriteLine("Name: " + name);
                        Console.WriteLine("Age: " + age);
                        Console.WriteLine("Marks: " + marks);
                        Console.WriteLine("----------------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }

}
