

namespace CSV
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    class DatabaseToCSV
    {
        static void Main()
        {
            string connectionString = "your_connection_string_here"; // Update with your DB connection
            string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
            string outputFilePath = "EmployeeReport.csv";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        // Write CSV Header
                        writer.WriteLine("Employee ID,Name,Department,Salary");

                        // Write CSV Rows
                        while (reader.Read())
                        {
                            string line = $"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}";
                            writer.WriteLine(line);
                        }
                    }
                }

                Console.WriteLine($"CSV report generated successfully: {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

}
