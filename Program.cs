﻿namespace ExceptionHandle
{
    namespace Exception
    {
        using System;
        using System.IO;

        class Program
        {
            static void Main()
            {
                string filePath = "data.txt";

                try
                {
                    // Attempt to read the file
                    string content = File.ReadAllText(filePath);
                    Console.WriteLine("File Contents:");
                    Console.WriteLine(content);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found.");
                }
                catch (IOException ex)
                {
                    Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
                }
            }
        }

    }



}
