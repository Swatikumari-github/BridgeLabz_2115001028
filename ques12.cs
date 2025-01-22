using System;

class ques12
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the base:");
        double baseInch = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Convert.ToDouble(Console.ReadLine());
		double convFactor=6.4516;
		double areaInch=0.5*baseInch*height;
		double areaCm=areaInch*convFactor;

      
     
        Console.WriteLine("The area of the triangle is: " + areaInch + " square inches.");
        Console.WriteLine("The area of the triangle is: " + areaCm.ToString("F2") + " square centimeters.");
      

        Console.ReadLine();
    }
}