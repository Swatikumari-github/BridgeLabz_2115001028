namespace Streams
{
    using System;
    using System.IO;

    class FileHandling
    {
        static void Main()
        {
            string sourceFile = "source.txt";
            string destinationFile = "destination.txt";

            try
            {
                // Check if the source file exists
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Error: Source file does not exist.");
                    return;
                }

                // Open FileStream for reading
                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    // Read from source and write to destination
                    while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fsWrite.Write(buffer, 0, bytesRead);
                    }
                }

                Console.WriteLine("File copied successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}
