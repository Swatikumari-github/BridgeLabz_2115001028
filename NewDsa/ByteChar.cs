using System;
using System.Collections.Generic;
using System.Linq;


namespace NewDsa
{
   
    class ByteChar
    {
        static void Main()
        {
            string filePath = "sample.bin"; // Change this to your actual file path

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("File Content:\n" + content);
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
