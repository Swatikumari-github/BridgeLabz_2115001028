using System;


 class Toggle
{
    static string ToggleCase(string str)
    {
        char[] charArray = str.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            // Check if the character is uppercase
            if (char.IsUpper(charArray[i]))
            {
                // Convert to lowercase
                charArray[i] = char.ToLower(charArray[i]);
            }
            else if (char.IsLower(charArray[i]))
            {
                // Convert to uppercase
                charArray[i] = char.ToUpper(charArray[i]);
            }
        }

        // Return the modified string
        return new string(charArray);
    }
    public static void Main()
    {
       
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Call the ToggleCase function
        string result = ToggleCase(input);

        // Display the result
        Console.WriteLine("String with toggled case: " + result);
}		
}
