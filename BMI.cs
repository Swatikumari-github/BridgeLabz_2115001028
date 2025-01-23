using System;

class BMI
{
    static void Bmi(Double weight,double heightCm)
    {   
	    double heightM=heightCm/100;
		double bmi=weight/(heightM*heightM);
		Console.WriteLine("your bmi is:" +bmi);
		if(bmi<18.5)
		{
		   Console.WriteLine("Weight status: UnderWeight");
		}
		else if(bmi >= 18.5 && bmi < 24.9)
		{
		     Console.WriteLine("Weight Status: Normal weight");
		}
		else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Weight Status: Overweight");
        }
        else
        {
            Console.WriteLine("Weight Status: Obesity");
        }
    }

    static void Main(String[] args)
    {
        Console.WriteLine("Enter the weight:");
       double weight=Convert.ToDouble(Console.ReadLine());
	   Console.WriteLine("Enter the weight:");
       double heightCm=Convert.ToDouble(Console.ReadLine());
        Bmi(weight,heightCm);
        Console.ReadLine();
    }
}
