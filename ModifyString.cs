

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;

    public class StringModifier
    {
        public static string ReplaceMultipleSpaces(string inputText)
        {
            // Use Regex.Replace to replace multiple spaces with a single space
            return Regex.Replace(inputText, @"\s+", " ");
        }
    }

    class ModifyString
    {
        static void Main()
        {
            // Example input text
            string inputText = "This  is   an    example   with  multiple  spaces.";

            // Replace multiple spaces with a single space
            string result = StringModifier.ReplaceMultipleSpaces(inputText);

            // Print the modified string
            Console.WriteLine(result);
        }
    }

}
