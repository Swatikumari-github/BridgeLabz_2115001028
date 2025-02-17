

namespace Complexity
{
    using System;
    using System.Diagnostics;
    using System.IO;

    class LargeFileReadingComparison
    {
        static void Main()
        {
            string filePath = "file.txt";

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            ReadFileWithStreamReader(filePath);
            stopwatch.Stop();
            long streamReaderTime = stopwatch.ElapsedMilliseconds;

            stopwatch.Restart();
            ReadFileWithFileStream(filePath);
            stopwatch.Stop();
            long fileStreamTime = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"StreamReader Time: {streamReaderTime} ms");
            Console.WriteLine($"FileStream Time: {fileStreamTime} ms");
        }

        static void ReadFileWithStreamReader(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (reader.Read() != -1) { }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void ReadFileWithFileStream(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (reader.Read() != -1) { }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
