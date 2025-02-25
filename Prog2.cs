

namespace CSV
{

    using System;
    using System.IO;

    class Prog2
    {
        static void Main()
        {
            // Path to the CSV file where you want to write the data
            string filePath = "employees.csv";

            // Create or overwrite the CSV file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write the header row
                writer.WriteLine("ID,Name,Department,Salary");

                // Write employee records (ID, Name, Department, Salary)
                writer.WriteLine("1,swati,Engineering,75000");
                writer.WriteLine("2,raj,Marketing,80000");
                writer.WriteLine("3,Sam,HR,60000");
                writer.WriteLine("4,ram,Engineering,95000");
                writer.WriteLine("5,Jay,Sales,70000");

                Console.WriteLine("Employee data has been written to the file successfully.");
            }
        }
    }

}
