using System;

class EmployeeDetails
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    public EmployeeDetails(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: "+Id);
        Console.WriteLine("Name: "+Name);
        Console.WriteLine("Salary: "+Salary);
    }
}

class Program
{
    static void Main()
    {
        EmployeeDetails emp1 = new EmployeeDetails("Alice", 101, 50000);
        emp1.DisplayDetails();
    }
}
