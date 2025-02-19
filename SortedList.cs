using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    

    class SortedList
    {
        static void Main()
        {
            // Define a HashSet
            HashSet<int> numberSet = new HashSet<int> { 5, 3, 9, 1 };

            // Convert HashSet to a sorted list
            List<int> sortedList = numberSet.OrderBy(x => x).ToList();

            // Output the sorted list
            Console.WriteLine("Sorted List: [" + string.Join(", ", sortedList) + "]");
        }
    }

}
