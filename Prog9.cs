

namespace CSV
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Student(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public override string ToString()
        {
            return $"Student {{ Name: {Name}, Age: {Age}, Email: {Email} }}";
        }
    }

    class CSVToStudent
    {
        static void Main()
        {
            string filePath = "students.csv"; // Change this to your CSV file path
            List<Student> students = new List<Student>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    reader.ReadLine(); // Skip the header row

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        if (data.Length < 3)
                        {
                            Console.WriteLine($"Skipping invalid row: {line}");
                            continue;
                        }

                        string name = data[0].Trim();
                        int age;
                        if (!int.TryParse(data[1].Trim(), out age))
                        {
                            Console.WriteLine($"Invalid age format in row: {line}");
                            continue;
                        }

                        string email = data[2].Trim();
                        students.Add(new Student(name, age, email));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }

            // Print all Student objects
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }


}
