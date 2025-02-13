using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
   
    class CircularTour
    {
        class PetrolPump
        {
            public int Petrol, Distance;

            public PetrolPump(int petrol, int distance)
            {
                Petrol = petrol;
                Distance = distance;
            }
        }

        public int FindStart(PetrolPump[] pumps)
        {
            int start = 0, deficit = 0, surplus = 0;

            for (int i = 0; i < pumps.Length; i++)
            {
                surplus += pumps[i].Petrol - pumps[i].Distance;
                if (surplus < 0)
                {
                    start = i + 1;
                    deficit += surplus;
                    surplus = 0;
                }
            }
            return (surplus + deficit >= 0) ? start : -1;
        }

        public static void Main()
        {
            Console.WriteLine("Enter the number of petrol pumps:");
            int n = int.Parse(Console.ReadLine());
            PetrolPump[] pumps = new PetrolPump[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter petrol and distance for pump {i + 1}:");
                string[] input = Console.ReadLine().Split();
                int petrol = int.Parse(input[0]);
                int distance = int.Parse(input[1]);
                pumps[i] = new PetrolPump(petrol, distance);
            }

            CircularTour tour = new CircularTour();
            int startIndex = tour.FindStart(pumps);
            Console.WriteLine("Starting point: " + startIndex);
        }
    }
}
