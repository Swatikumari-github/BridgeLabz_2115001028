using System;
using System.IO;


namespace ExceptionHandle
{
    
    

    class Prog5
    {
        static void Main()
        {
            try
            {
                using (StreamReader reader = new StreamReader("info.txt"))
                {
                    string firstLine = reader.ReadLine();
                    Console.WriteLine("First line: " + firstLine);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }


}
