using System;

class EmployeeBonusCalculator
{
    static void Main()
    {
        int numEmployees = 10;
        int[,] employeeData = GenerateEmployeeData(numEmployees);
        double[,] bonusData = CalculateBonusAndNewSalary(employeeData);

        DisplayBonusDetails(employeeData, bonusData);
    }

    static int[,] GenerateEmployeeData(int numEmployees)
    {
        Random rand = new Random();
        int[,] data = new int[numEmployees, 2];

        for (int i = 0; i < numEmployees; i++)
        {
            data[i, 0] = rand.Next(20000, 100001);
            data[i, 1] = rand.Next(1, 11);
        }

        return data;
    }

    static double[,] CalculateBonusAndNewSalary(int[,] employeeData)
    {
        int numEmployees = employeeData.GetLength(0);
        double[,] results = new double[numEmployees, 2];

        for (int i = 0; i < numEmployees; i++)
        {
            int salary = employeeData[i, 0];
            int yearsOfService = employeeData[i, 1];

            double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02;
            double bonus = salary * bonusPercentage;
            double newSalary = salary + bonus;

            results[i, 0] = Math.Round(bonus, 2);
            results[i, 1] = Math.Round(newSalary, 2);
        }

        return results;
    }

    static void DisplayBonusDetails(int[,] employeeData, double[,] bonusData)
    {
        Console.WriteLine("Employee Bonus Details:\n");
        Console.WriteLine("EmpID\tSalary\tYears of Service\tBonus\tNew Salary");

        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        for (int i = 0; i < employeeData.GetLength(0); i++)
        {
            int salary = employeeData[i, 0];
            int yearsOfService = employeeData[i, 1];
            double bonus = bonusData[i, 0];
            double newSalary = bonusData[i, 1];

            totalOldSalary += salary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine(i + 1 + "\t" + salary + "\t" + yearsOfService + "\t\t" + bonus + "\t" + newSalary);
        }

        Console.WriteLine("\nTotal Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
        Console.WriteLine("Total Bonus: " + totalBonus);
    }
}
