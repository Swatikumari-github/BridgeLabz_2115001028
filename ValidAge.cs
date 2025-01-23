using System;
class ques5{
   static void ValidAge(int age)
   {
        if(age>=18){
	    
		Console.WriteLine("The person age is"  + age +" and can vote");
		}
		else{
		Console.WriteLine("The person age is" + age +" and cannot vote");
		}
	}
	static void Main(string [] args)
	{
	   Console.WriteLine("enter the age:");
	   int age=Convert.ToInt32(Console.ReadLine());
	   ValidAge(age);
	   Console.ReadLine();
	 }
}