

namespace CSV
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class CSVValidator
    {
        static void Main()
        {
            string filePath = "data.csv"; // Change to your CSV file path

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File not found!");
                return;
            }

            // Regular expressions for validation
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            string phonePattern = @"^\d{10}$";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Read header
                if (headerLine == null)
                {
                    Console.WriteLine("Error: Empty CSV file.");
                    return;
                }

                Console.WriteLine(headerLine); // Print headers
                string line;
                int lineNumber = 1;

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;
                    string[] fields = line.Split(',');

                    if (fields.Length < 2) // Ensure we have at least Email and Phone Number columns
                    {
                        Console.WriteLine($"Line {lineNumber}: Error - Missing columns.");
                        continue;
                    }

                    string email = fields[0].Trim();
                    string phone = fields[1].Trim();

                    bool isValid = true;

                    if (!Regex.IsMatch(email, emailPattern))
                    {
                        Console.WriteLine($"Line {lineNumber}: Invalid Email - {email}");
                        isValid = false;
                    }

                    if (!Regex.IsMatch(phone, phonePattern))
                    {
                        Console.WriteLine($"Line {lineNumber}: Invalid Phone Number - {phone}");
                        isValid = false;
                    }

                    if (isValid)
                    {
                        Console.WriteLine($"Line {lineNumber}: Valid");
                    }
                }
            }
        }
    }

}
