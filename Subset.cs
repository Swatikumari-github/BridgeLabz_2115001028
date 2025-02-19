using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
  
    class Subset
    {
        static void Main()
        {
            // Define two sets
            HashSet<int> firstSet = new HashSet<int> { 2, 3 };
            HashSet<int> secondSet = new HashSet<int> { 1, 2, 3, 4 };

            // Check if firstSet is a subset of secondSet
            bool isSubset = firstSet.IsSubsetOf(secondSet);

            // Output the result
            Console.WriteLine(isSubset ? "true" : "false");
        }
    }


}
