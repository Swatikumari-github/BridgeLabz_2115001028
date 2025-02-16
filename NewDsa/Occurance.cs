using System;
using System.Collections.Generic;
using System.Linq;

namespace NewDsa
{
  

    class Occurance
    {
        static void Main()
        {
            string filePath = "sample.txt"; // Change this to your actual file path
            string wordToFind = "hello"; // Change this to the word you want to count
            int count = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split line into words and count occurrences (case-insensitive)
                        string[] words = line.Split(new char[] { ' ', '\t', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in words)
                        {
                            if (word.Equals(wordToFind, StringComparison.OrdinalIgnoreCase))
                            {
                                count++;
                            }
                        }
                    }
                }

                Console.WriteLine($"The word \"{wordToFind}\" appears {count} times in the file.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The file was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}
