using System;

class Program

{
    public static int Perimeter;
	  public static float totalRounds;
	static void totalRound(int s1, int s2,int s3)
	{
	  Perimeter=s1+s2+s3;
	  int DistanceInM=5000;
	  totalRounds=DistanceInM/Perimeter;
	}
	static void Display()
	{
	Console.WriteLine("the total no of rounds is:" +totalRounds);
	}
	
    static void Main(string[] args)
    {
     Console.WriteLine("Enter the side1:");
	 int s1=Convert.ToInt32(Console.ReadLine());
	 Console.WriteLine("Enter the side2:");
	 int s2=Convert.ToInt32(Console.ReadLine());
	  Console.WriteLine("Enter the side3:");
	 int s3=Convert.ToInt32(Console.ReadLine());
      totalRound(s1,s2,s3);
	
	 Display();
	 
    }
}