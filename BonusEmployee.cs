using System;

class Program
{
    static void BonusEmployee()
    {
        const int numEmployees = 10;
        double[] salaries = new double[numEmployees];
        double[] yearsOfService = new double[numEmployees];
        double[] bonuses = new double[numEmployees];
        double[] newSalaries = new double[numEmployees];

        double totalOldSalary = 0;
        double totalBonus = 0;
        double totalNewSalary = 0;
		 for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine("Enter details for Employee" +(i + 1));
			 while (true)
            {
                Console.Write("Enter Salary: ");
				double salary=Convert.ToDouble(Console.ReadLine());
                if (salary > 0)
                {
                    salaries[i] = salary;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid salary. Please enter a positive number.");
                }
            }
			  while (true)
            {
                Console.Write("Enter Years of Service: ");
				double years=Convert.ToDouble(Console.ReadLine());
                if (years >= 0)
                {
                    yearsOfService[i] = years;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid years of service. Please enter a non-negative number.");
                }
            }
        }
		   for (int i = 0; i < numEmployees; i++)
        {
            double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusPercentage;
            newSalaries[i] = salaries[i] + bonuses[i];

            totalOldSalary += salaries[i];
            totalBonus += bonuses[i];
            totalNewSalary += newSalaries[i];
        }
		Console.WriteLine("\nSummary:");
        Console.WriteLine("Total Old Salary:" +totalOldSalary);
        Console.WriteLine("Total Bonus Payout:" +totalBonus);
        Console.WriteLine("Total New Salary:" +totalNewSalary);
		  Console.WriteLine("\nDetails of Each Employee:");
        for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine( "Employee {0}: Old Salary = {1:C}, Bonus = {2:C}, New Salary = {3:C}", 
        i + 1, 
        salaries[i], 
        bonuses[i], 
        newSalaries[i]);
        }
		

    }

    static void Main(string[] args)
    {
        
BonusEmployee();
    }
}