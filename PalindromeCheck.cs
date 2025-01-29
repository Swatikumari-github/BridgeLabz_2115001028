using System;
class PalindromeCheck
{
   static bool CheckPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (char.ToLower(str[left]) != char.ToLower(str[right]))
                return false;
            left++;
            right--;
        }
        return true;
    }
 static void Main(string [] args)
 {
        
          Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        bool isPalindrome = CheckPalindrome(input);
        
        Console.WriteLine(isPalindrome ? "The string is a palindrome." : "The string is not a palindrome.");
 }
}