using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Colections
{
  
    class WordFrequencyCounter
    {
        public static void CountWordFrequencies(string filePath)
        {
            // Initialize a dictionary to store word frequencies
            Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

            try
            {
                // Read the file content
                string fileContent = File.ReadAllText(filePath);

                // Use regular expression to split text into words and convert them to lowercase
                string[] wordList = Regex.Split(fileContent.ToLower(), @"\W+");

                // Iterate through each word and update the frequency in the dictionary
                foreach (var word in wordList)
                {
                    if (!string.IsNullOrEmpty(word))
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
                }

                // Output the word frequencies
                Console.WriteLine("Word Frequencies:");
                foreach (var entry in frequencyMap)
                {
                    Console.WriteLine($"\"{entry.Key}\": {entry.Value}");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("An error occurred: " + error.Message);
            }
        }

        static void Main()
        {
            // Example file path (adjust to the location of your text file)
            string filePath = "sample.txt"; // Provide the path to your text file

            // Call the function to count word frequencies
            CountWordFrequencies(filePath);
        }
    }

}
