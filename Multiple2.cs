using System;
class Program{
   static void Multiple2(int []num,int a)
   {
      for(int i=5;i<9;i++)
	  {
	     num[i]=a*(i+1);
		 Console.WriteLine(a +"*" +(i+1) +"=" +(num[i]));
	   }
	}
	static void Main(string [] args)
	{
	  int []num=new int[10];
	  Console.WriteLine("enter the number ");
	  int a=Convert.ToInt32(Console.ReadLine());
      Multiple2(num,a);
	  }
	 }
