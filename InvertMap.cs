using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    
    class DictionaryInverter
    {
        public static Dictionary<V, List<K>> InvertDictionary<K, V>(Dictionary<K, V> originalDict)
        {
            // Create a new dictionary to store the inverted key-value pairs
            Dictionary<V, List<K>> invertedDict = new Dictionary<V, List<K>>();

            // Iterate over each key-value pair in the original dictionary
            foreach (var pair in originalDict)
            {
                // Check if the value already exists in the inverted dictionary
                if (invertedDict.ContainsKey(pair.Value))
                {
                    // If the value exists, add the key to the list of keys for that value
                    invertedDict[pair.Value].Add(pair.Key);
                }
                else
                {
                    // If the value does not exist, create a new list with the current key
                    invertedDict[pair.Value] = new List<K> { pair.Key };
                }
            }

            return invertedDict;
        }

        static void Main()
        {
            // Example input dictionary
            Dictionary<string, int> originalDict = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

            // Invert the dictionary
            var invertedDict = InvertDictionary(originalDict);

            // Output the inverted dictionary
            Console.WriteLine("Inverted Dictionary:");
            foreach (var pair in invertedDict)
            {
                Console.WriteLine($"{pair.Key} = [{string.Join(", ", pair.Value)}]");
            }
        }
    }

}
