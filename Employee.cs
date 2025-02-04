using System;

class Employee
{
    public static string CompanyName = "CG Solutions Ltd.";
    private static int TotalEmployees = 0;

    public readonly int Id;
    private string Name;
    private string Designation;

    public Employee(string name, int id, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        TotalEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + TotalEmployees);
    }

    public void DisplayDetails()
    {
        if (this is Employee)
        {
            Console.WriteLine("Name: " + this.Name + ", ID: " + this.Id + ", Designation: " + this.Designation);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Company Name: " + Employee.CompanyName);

        Console.Write("Enter the number of employees : ");
        int employeeCount = Convert.ToInt32(Console.ReadLine());

        Employee[] employees = new Employee[employeeCount];

        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine("\nEnter details of Employee " + (i + 1));

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Designation: ");
            string designation = Console.ReadLine();

            employees[i] = new Employee(name, id, designation);
        }

        Console.WriteLine("\nEmployee Details:");
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }

        Employee.DisplayTotalEmployees();
    }
}