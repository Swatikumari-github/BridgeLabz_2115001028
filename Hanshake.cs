using System;

class Program

{
    public static int Handshake;
	//method to find the total number of handshakes
    static void HandShakes(int num)
    {
	   Handshake=(num*(num-1))/2;
	}
	//method to display the result
	static void Display()
	{
	  Console.WriteLine("The max number of handshakes are:" +Handshake);
	 }
    static void Main(string[] args)
    {
     Console.WriteLine("Enter the number of students:");
	 int num=Convert.ToInt32(Console.ReadLine());
	 HandShakes(num);
	 Display();
	 
    }
}