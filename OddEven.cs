using System;

class Program
{
    static void OddEven(int a)
    {
        if (a > 0)
        {
            int[] even = new int[(int)(a / 2) + 1];
            int[] odd = new int[(int)(a / 2) + 1];
            int Oindex = 0;
            int Eindex = 0;

            // Populate even and odd arrays
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    even[Eindex] = i;
                    Eindex++;
                }
                else
                {
                    odd[Oindex] = i;
                    Oindex++;
                }
            }

            // Display even array elements
            Console.WriteLine("Elements of the even array:");
            for (int i = 0; i < Eindex; i++)
            {
                Console.WriteLine(even[i]);
            }

            // Display odd array elements
            Console.WriteLine("Elements of the odd array:");
            for (int i = 0; i < Oindex; i++)
            {
                Console.WriteLine(odd[i]);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int a = Convert.ToInt32(Console.ReadLine());

        OddEven(a);
    }
}
