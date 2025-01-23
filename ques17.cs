using System;
class ques16{
   static void EmployeeSalary()
   {
       Console.WriteLine("enter the employee salary");
	  double salary=Convert.ToDouble(Console.ReadLine());
	  Console.WriteLine("enter the year of service");
	  int YearOfService=Convert.ToInt32(Console.ReadLine());
	  
	   if(YearOfService>5){
		   double bonus=salary*0.5;
		   Console.WriteLine("the bonus given to the employee is:" +bonus);
	   }
	   else{
		   Console.WriteLine("there is no bonus as the year of service is less than 5");
		
	}
   }
	static void Main(string [] args)
	{
	  
	  EmployeeSalary();
	  Console.ReadLine();
	 }
}