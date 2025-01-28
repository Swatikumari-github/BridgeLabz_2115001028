using System;

class Program
{
    static void SI()
    {
	   Console.WriteLine("enter the principal");
	    int P=Convert.ToInt32(Console.ReadLine());
	   Console.WriteLine("enter the rate");
	   float R=float.Parse(Console.ReadLine());
	   Console.WriteLine("enter the Time");
	   float T=float.Parse(Console.ReadLine());
	   float SI=((float)P*R*T)/100;
	   Console.WriteLine("The simple interest is:" +SI);
	   
	   
	  
	   
    }
    static void Main(string[] args)
    {
     SI();
    }
}
