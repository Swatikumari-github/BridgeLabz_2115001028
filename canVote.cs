using System;
class Program{
   static void canVote(int []ages)
   {
      for(int i=0;i<10;i++){
	   if(ages[i]<0){
	     Console.WriteLine("enter the valid age");
		 }
		 else if(ages[i]>=18)
		 {
		 Console.WriteLine("you can vote as your age is" +ages[i]);
		 }
		 else{
		 Console.WriteLine("no you cannot vote");
		 }
	  }
	}
	static void Main(string [] args)
	{
	  int []ages=new int[10];
	  Console.WriteLine("enter the age of students");
	  for(int i=0;i<10;i++)
	  {
	     ages[i]=Convert.ToInt32(Console.ReadLine());
	   }
	   canVote(ages);
	  }
	 }
	 