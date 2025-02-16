using System;
using System.Collections.Generic;
using System.Linq;
namespace NewDsa
{
   

    class ReadFile
    {
        static void Main()
        {
            string filePath = "sample.txt"; // Change this to your actual file path

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
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
