using System;
using System.IO;

namespace Streams
{
    

    class StudentData
    {
        static string filePath = "student_data.bin";

        static void Main()
        {
            try
            {
                // Writing student details to a binary file
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    Console.Write("Enter Roll Number: ");
                    int rollNumber = int.Parse(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter GPA: ");
                    float gpa = float.Parse(Console.ReadLine());

                    writer.Write(rollNumber);
                    writer.Write(name);
                    writer.Write(gpa);
                }

                Console.WriteLine("Student data has been saved successfully.");

                // Reading student details from the binary file
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    int rollNumber = reader.ReadInt32();
                    string name = reader.ReadString();
                    float gpa = reader.ReadSingle();

                    Console.WriteLine("\nRetrieved Student Details:");
                    Console.WriteLine($"Roll Number: {rollNumber}");
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"GPA: {gpa}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}
