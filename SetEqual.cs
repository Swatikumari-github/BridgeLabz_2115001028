using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
   

    class SetEqual
    {
        static bool AreSetsIdentical(HashSet<int> firstSet, HashSet<int> secondSet)
        {
            return firstSet.SetEquals(secondSet);
        }

        static void Main()
        {
            // Define two sets with new variable names
            HashSet<int> firstSet = new HashSet<int> { 1, 2, 3 };
            HashSet<int> secondSet = new HashSet<int> { 3, 2, 1 };

            // Compare sets
            bool areSetsEqual = AreSetsIdentical(firstSet, secondSet);

            // Output result
            Console.WriteLine(areSetsEqual ? "true" : "false");
        }
    }

}
