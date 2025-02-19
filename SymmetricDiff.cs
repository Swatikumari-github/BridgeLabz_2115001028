using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    

    class SymmetricDiff
    {
        static void Main()
        {
            // Define two sets with new variable names
            HashSet<int> firstGroup = new HashSet<int> { 1, 2, 3 };
            HashSet<int> secondGroup = new HashSet<int> { 3, 4, 5 };

            // Compute the symmetric difference
            HashSet<int> uniqueElements = new HashSet<int>(firstGroup);
            uniqueElements.SymmetricExceptWith(secondGroup);

            // Output the result
            Console.WriteLine("Symmetric Difference: {" + string.Join(", ", uniqueElements) + "}");
        }
    }

}
