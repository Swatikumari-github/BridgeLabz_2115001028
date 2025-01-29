using System;


 class Compare
{
    static int CompareStrings(string str1, string str2)
    {
        // Loop through both strings and compare character by character
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            // Compare the characters at the current position
            if (str1[i] < str2[i])
            {
                return -1; // str1 comes before str2
            }
            else if (str1[i] > str2[i])
            {
                return 1; // str1 comes after str2
            }
        }

        // If the strings are of different lengths, the shorter string comes first
        if (str1.Length < str2.Length)
        {
            return -1; // str1 comes before str2
        }
        else if (str1.Length > str2.Length)
        {
            return 1; // str1 comes after str2
        }

        return 0; // Strings are equal
    }
    public static void Main()
    {
       
       Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();
        
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        // Call the CompareStrings function
        int result = CompareStrings(str1, str2);

        // Display the result of comparison
        if (result < 0)
        {
            Console.WriteLine(str1 +" comes before " +str2 +" in lexicographical order.");
        }
        else if (result > 0)
        {
            Console.WriteLine(str1 +" comes before " +str2 +" in lexicographical order.");
        }
        else
        {
            Console.WriteLine(str1 +" is equal to " +str2);
        }
     
}		
}
