using System;
using System.Collections.Generic;
using System.Linq;


namespace NewDsa
{
   

    class Read
    {
        static void Main()
        {
            string filePath = "user_input.txt"; // File to store user input

            try
            {
                Console.WriteLine("Enter text (type 'exit' to stop):");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    while (true)
                    {
                        string input = Console.ReadLine();

                        if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                            break;

                        writer.WriteLine(input);
                    }
                }

                Console.WriteLine($"User input has been saved to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}
