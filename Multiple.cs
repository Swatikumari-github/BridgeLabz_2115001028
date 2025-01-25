using System;
class Program{
   static void Multiple(int []num,int a)
   {
      for(int i=0;i<10;i++)
	  {
	     num[i]=a*(i+1);
		 Console.WriteLine(a +"*" +(i+1) +"=" +(num[i]));
	   }
	}
	static void Main(string [] args)
	{
	  int []num=new int[10];
	  Console.WriteLine("enter the number");
	  int a=Convert.ToInt32(Console.ReadLine());
	 
	   Multiple(num,a);
	  }
	 }