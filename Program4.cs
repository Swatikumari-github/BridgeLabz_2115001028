using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Streams
{
    

    [Serializable]
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    class Program4
    {
        static string filePath = "employees.json";

        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                Console.WriteLine("Enter number of employees: ");
                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Employee emp = new Employee();

                    Console.Write("Enter Employee ID: ");
                    emp.Id = int.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Name: ");
                    emp.Name = Console.ReadLine();

                    Console.Write("Enter Department: ");
                    emp.Department = Console.ReadLine();

                    Console.Write("Enter Salary: ");
                    emp.Salary = double.Parse(Console.ReadLine());

                    employees.Add(emp);
                }

                // Serialize employee list to file
                string jsonString = JsonSerializer.Serialize(employees);
                File.WriteAllText(filePath, jsonString);
                Console.WriteLine("Employees saved successfully.");

                // Deserialize and display employees
                string readJson = File.ReadAllText(filePath);
                List<Employee> deserializedEmployees = JsonSerializer.Deserialize<List<Employee>>(readJson);
                Console.WriteLine("\nRetrieved Employees:");
                foreach (var emp in deserializedEmployees)
                {
                    Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
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
