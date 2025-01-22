using System;


    class ques6
    {
	    static void TotalIncome(int salary,int bonus)
		{
		   int totalIncome=salary+bonus;
		   Console.WriteLine("total income of the employee is:" +totalIncome);
		}
        static void Main(string[] args)
        {
            Console.WriteLine("enter the salary");
			
			int salary=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter the bonus");
			
			int bonus=Convert.ToInt32(Console.ReadLine());
			
			TotalIncome(salary,bonus);
            Console.ReadLine();
        }
    }
