using System;
class FriendsComparison

{
     public static string FindYoungest(string[] names, int[] ages)
    {
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }
        return names[youngestIndex];
    }
      public static string FindTallest(string[] names, double[] heights)
    {
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }
        return names[tallestIndex];
    }
     
   static void Main(string [] args)
   {    
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < names.Length; i++)
        {
            Console.Write("Enter the age of {0}: " +names[i]);
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter the height (in cm) of {0}: " +names[i]);
            heights[i] = double.Parse(Console.ReadLine());
        }

        string youngest = FindYoungest(names, ages);
        string tallest = FindTallest(names, heights);

        Console.WriteLine("The youngest friend is: {0}"  +youngest);
        Console.WriteLine("The tallest friend is: {0}"   +tallest);
      
        Console.ReadLine();
	  
   }
}