using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Streams
{
   

    class WordCount
    {
        static void Main()
        {
            string filePath = "textfile.txt";
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            try
            {
                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.Split(new char[] { ' ', '\t', '\n', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string word in words)
                        {
                            if (wordFrequency.ContainsKey(word))
                                wordFrequency[word]++;
                            else
                                wordFrequency[word] = 1;
                        }
                    }
                }

                Console.WriteLine($"Total unique words: {wordFrequency.Count}");
                Console.WriteLine("Top 5 most frequent words:");

                foreach (var word in wordFrequency.OrderByDescending(w => w.Value).Take(5))
                {
                    Console.WriteLine($"{word.Key}: {word.Value} times");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The file was not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            }
        }
    }

}
