using System;


    class ques5
    {
	    static void FToC(float fahrenheit)
		{
		   float C= (fahrenheit - 32) * 5/9;
		   Console.WriteLine("temperature in fahrenheit is:" +C);
		}
        static void Main(string[] args)
        {
            Console.WriteLine("input temp in celcius");
			
			float fahrenheit=float.Parse(Console.ReadLine());
			FToC(fahrenheit);
			
            Console.ReadLine();
        }
    }
