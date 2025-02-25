

namespace CSV
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    using Newtonsoft.Json;

    class Student2
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Student2(string id, string name, int age, string email)
        {
            ID = id;
            Name = name;
            Age = age;
            Email = email;
        }
    }

    class JSONCSVConverter
    {
        // Convert JSON to CSV
        public static void JSONToCSV(string jsonFilePath, string csvFilePath)
        {
            try
            {
                // Read JSON data from file
                string json = File.ReadAllText(jsonFilePath);
                List<Student2> students = JsonConvert.DeserializeObject<List<Student2>>(json);

                // Write CSV file
                using (StreamWriter writer = new StreamWriter(csvFilePath))
                {
                    // Write CSV header
                    writer.WriteLine("ID,Name,Age,Email");

                    // Write data rows
                    foreach (var student in students)
                    {
                        writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Email}");
                    }
                }

                Console.WriteLine("CSV file generated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error converting JSON to CSV: " + ex.Message);
            }
        }

        // Convert CSV to JSON
        public static void CSVToJSON(string csvFilePath, string jsonFilePath)
        {
            try
            {
                List<Student2> students = new List<Student2>();

                using (StreamReader reader = new StreamReader(csvFilePath))
                {
                    string line;
                    reader.ReadLine(); // Skip header

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        if (data.Length == 4)
                        {
                            students.Add(new Student2(data[0].Trim(), data[1].Trim(), int.Parse(data[2].Trim()), data[3].Trim()));
                        }
                    }
                }

                // Write JSON file
                string json = JsonConvert.SerializeObject(students, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);

                Console.WriteLine("JSON file generated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error converting CSV to JSON: " + ex.Message);
            }
        }
    }

    class Prog14
    {
        static void Main()
        {
            string jsonFilePath = "students.json"; // JSON file path
            string csvFilePath = "students.csv";   // CSV file path

            // Convert JSON to CSV
            JSONCSVConverter.JSONToCSV(jsonFilePath, csvFilePath);

            // Convert CSV back to JSON
            string newJsonFilePath = "students_converted.json";
            JSONCSVConverter.CSVToJSON(csvFilePath, newJsonFilePath);
        }
    }

}
