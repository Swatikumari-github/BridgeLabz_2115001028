using System;

class ques16
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number of students");
		int n=Convert.ToInt32(Console.ReadLine());
		int maxHandshake=(n*(n-1))/2;
		Console.WriteLine("the total no of handshakes:" +maxHandshake);		

        Console.ReadLine(); 
    }
}