using System;
class ReverseString
{
   static string StringReverse(string str)
    {
        char[] charArray = new char[str.Length];
        for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
        {
            charArray[i] = str[j];
        }
        return new string(charArray);
    }
 static void Main(string [] args)
 {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        string reversed = StringReverse(input);
        
        Console.WriteLine("Reversed String: " +reversed);
 }
}