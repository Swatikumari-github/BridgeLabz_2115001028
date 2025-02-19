using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    
    class UnionIntersection
    {
        static void Main()
        {
            // Define two sets with new variable names
            HashSet<int> firstSet = new HashSet<int> { 1, 2, 3 };
            HashSet<int> secondSet = new HashSet<int> { 3, 4, 5 };

            // Compute the union
            HashSet<int> combinedSet = new HashSet<int>(firstSet);
            combinedSet.UnionWith(secondSet);

            // Compute the intersection
            HashSet<int> commonElementsSet = new HashSet<int>(firstSet);
            commonElementsSet.IntersectWith(secondSet);

            // Output the results
            Console.WriteLine("Union: {" + string.Join(", ", combinedSet) + "}");
            Console.WriteLine("Intersection: {" + string.Join(", ", commonElementsSet) + "}");
        }
    }

}
