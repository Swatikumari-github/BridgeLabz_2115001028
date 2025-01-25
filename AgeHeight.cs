using System;

class Program
{
    static void AgeHeight()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];
		  for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter the age of:" +names[i]);
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter the height (in cm) of" +names[i]);
            heights[i] = double.Parse(Console.ReadLine());
        }
		int youngestAge = ages[0];
        string youngestFriend = names[0];
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < youngestAge)
            {
                youngestAge = ages[i];
                youngestFriend = names[i];
            }
        }
		   double tallestHeight = heights[0];
        string tallestFriend = names[0];
        for (int i = 1; i < 3; i++)
        {
            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                tallestFriend = names[i];
            }
        }
         Console.WriteLine("The youngest friend is:" +youngestFriend);
		  Console.WriteLine("The tallest friend is:" +tallestFriend);
		 


		

    }

    static void Main(string[] args)
    {
        
AgeHeight();
    }
}