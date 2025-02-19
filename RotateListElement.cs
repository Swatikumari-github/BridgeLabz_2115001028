using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    

    class RotateListElement
    {
        static List<int> RotateList(List<int> lst, int positions)
        {
            int n = lst.Count;
            positions = positions % n; // Handle cases where positions > n

            List<int> rotated = new List<int>();

            // Add elements from the rotation index to the end
            rotated.AddRange(lst.GetRange(positions, n - positions));
            // Add elements from the start to the rotation index
            rotated.AddRange(lst.GetRange(0, positions));

            return rotated;
        }

        static void Main()
        {
            List<int> lst = new List<int> { 10, 20, 30, 40, 50 };
            int rotateBy = 2;

            List<int> rotated = RotateList(lst, rotateBy);
            Console.WriteLine(string.Join(", ", rotated)); // Output: 30, 40, 50, 10, 20
        }
    }

}
