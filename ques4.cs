using System;


    class ques4
    {
	    static void CToF(float celcius)
		{
		   float F=(celcius*9.0f/5)+32;
		   Console.WriteLine("temperature in fahrenheit is:" +F);
		}
        static void Main(string[] args)
        {
            Console.WriteLine("input temp in celcius");
			
			float celcius=float.Parse(Console.ReadLine());
			CToF(celcius);
			
            Console.ReadLine();
        }
    }
