namespace CSV
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            // Path to your CSV file
            string filePath = "students.csv";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(filePath);

                // Loop through each line (start from the second line to skip the header)
                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] values = line.Split(',');

                    string studentId = values[0];
                    string name = values[1];
                    string age = values[2];
                    string marks = values[3];

                    // Print the student's information in a structured format
                    Console.WriteLine("Student ID: " + studentId);
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Age: " + age);
                    Console.WriteLine("Marks: " + marks);
                    Console.WriteLine("----------------------------");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }

}
