

namespace CSV
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Student1
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"{ID},{Name},{Age},{Marks},{Grade}";
        }
    }

    class MergeCSVFiles
    {
        static void Main()
        {
            string file1 = "students1.csv"; // ID, Name, Age
            string file2 = "students2.csv"; // ID, Marks, Grade
            string outputFile = "merged_students.csv";

            Dictionary<string, Student1> students = new Dictionary<string, Student1>();

            // Read students1.csv
            try
            {
                using (StreamReader reader = new StreamReader(file1))
                {
                    reader.ReadLine(); // Skip header
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        if (data.Length < 3) continue;

                        string id = data[0].Trim();
                        string name = data[1].Trim();
                        int age = int.Parse(data[2].Trim());

                        students[id] = new Student1 { ID = id, Name = name, Age = age };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file1: " + ex.Message);
                return;
            }

            // Read students2.csv and merge data
            try
            {
                using (StreamReader reader = new StreamReader(file2))
                {
                    reader.ReadLine(); // Skip header
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        if (data.Length < 3) continue;

                        string id = data[0].Trim();
                        int marks = int.Parse(data[1].Trim());
                        string grade = data[2].Trim();

                        if (students.ContainsKey(id))
                        {
                            students[id].Marks = marks;
                            students[id].Grade = grade;
                        }
                        else
                        {
                            students[id] = new Student1 { ID = id, Name = "Unknown", Age = 0, Marks = marks, Grade = grade };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file2: " + ex.Message);
                return;
            }

            // Write merged data to a new CSV file
            try
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine("ID,Name,Age,Marks,Grade");

                    foreach (var student in students.Values)
                    {
                        writer.WriteLine(student);
                    }
                }
                Console.WriteLine("Merged CSV file created successfully: " + outputFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing merged file: " + ex.Message);
            }
        }
    }

}
