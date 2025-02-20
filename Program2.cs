using System;
using System.IO;
using System.Diagnostics;

namespace Streams
{
   

    class Program2
    {
        static void Main()
        {
            string sourceFile = "largefile.dat";
            string destinationFileBuffered = "destination_buffered.dat";
            string destinationFileUnbuffered = "destination_unbuffered.dat";

            try
            {
                // Check if the source file exists
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Error: Source file does not exist.");
                    return;
                }

                Stopwatch stopwatch = new Stopwatch();

                // Buffered Stream Copy
                stopwatch.Start();
                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream fsWrite = new FileStream(destinationFileBuffered, FileMode.Create, FileAccess.Write))
                using (BufferedStream bsRead = new BufferedStream(fsRead, 4096))
                using (BufferedStream bsWrite = new BufferedStream(fsWrite, 4096))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bsWrite.Write(buffer, 0, bytesRead);
                    }
                }
                stopwatch.Stop();
                Console.WriteLine($"Buffered Stream Copy Time: {stopwatch.ElapsedMilliseconds} ms");

                // Unbuffered Stream Copy
                stopwatch.Reset();
                stopwatch.Start();
                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream fsWrite = new FileStream(destinationFileUnbuffered, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fsWrite.Write(buffer, 0, bytesRead);
                    }
                }
                stopwatch.Stop();
                Console.WriteLine($"Unbuffered Stream Copy Time: {stopwatch.ElapsedMilliseconds} ms");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}
