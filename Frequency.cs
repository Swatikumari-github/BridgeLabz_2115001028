using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
   

    class Program
    {
        static Dictionary<string, int> CountFrequency(List<string> items)
        {
            Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

            foreach (string word in items)
            {
                if (frequencyMap.ContainsKey(word))
                {
                    frequencyMap[word]++;
                }
                else
                {
                    frequencyMap[word] = 1;
                }
            }

            return frequencyMap;
        }

        static void Main()
        {
            List<string> inputList = new List<string> { "apple", "banana", "apple", "orange" };
            Dictionary<string, int> result = CountFrequency(inputList);

            // Print the result
            Console.WriteLine("Word Frequencies:");
            foreach (var pair in result)
            {
                Console.WriteLine($"\"{pair.Key}\": {pair.Value}");
            }
        }
    }


}
