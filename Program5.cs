using System;
using System.IO;
using System.Text;

namespace Streams
{
    

    class Program5
    {
        static void Main()
        {
            string sourceFile = "source.txt";
            string destinationFile = "destination.txt";

            try
            {
                // Check if source file exists
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Error: Source file does not exist.");
                    return;
                }

                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (BufferedStream bsRead = new BufferedStream(fsRead))
                using (StreamReader sr = new StreamReader(bsRead, Encoding.UTF8))
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                using (BufferedStream bsWrite = new BufferedStream(fsWrite))
                using (StreamWriter sw = new StreamWriter(bsWrite, Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line.ToLower());
                    }
                }

                Console.WriteLine("File has been successfully converted to lowercase and saved.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }

}
