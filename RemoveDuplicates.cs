using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{

    

    class RemoveDuplicate
    {
        static List<T> RemoveDuplicates<T>(List<T> inputList)
        {
            HashSet<T> seen = new HashSet<T>();
            List<T> result = new List<T>();

            foreach (T item in inputList)
            {
                if (!seen.Contains(item))
                {
                    seen.Add(item);
                    result.Add(item);
                }
            }
            return result;
        }

        static void Main()
        {
            List<int> numbers = new List<int> { 3, 1, 2, 2, 3, 4 };
            List<int> uniqueNumbers = RemoveDuplicates(numbers);

            Console.WriteLine("[" + string.Join(", ", uniqueNumbers) + "]");
        }
    }

}
