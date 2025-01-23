using System;

class FriendsComparison
 
{

    
    static void Main()
    {
        // Input ages and heights for Amar, Akbar, and Anthony
        Console.WriteLine("Enter the age of Amar: ");
        int AmarAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the height of Amar (in cm): ");
        int AmarHeight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the age of Akbar: ");
        int AkbarAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the height of Akbar (in cm): ");
        int AkbarHeight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the age of Anthony: ");
        int AnthonyAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the height of Anthony (in cm): ");
        int AnthonyHeight = Convert.ToInt32(Console.ReadLine());

        // Find the youngest friend
        int youngestAge = Math.Min(AmarAge, Math.Min(AkbarAge, AnthonyAge));
        string youngestFriend = "";

        if (youngestAge == AmarAge) youngestFriend = "Amar";
        else if (youngestAge == AkbarAge) youngestFriend = "Akbar";
        else youngestFriend = "Anthony";

        // Find the tallest friend
        int tallestHeight = Math.Max(AmarHeight, Math.Max(AkbarHeight, AnthonyHeight));
        string tallestFriend = "";

        if (tallestHeight == AmarHeight) tallestFriend = "Amar";
        else if (tallestHeight == AkbarHeight) tallestFriend = "Akbar";
        else tallestFriend = "Anthony";

        // Display results
        Console.WriteLine("the youngest friend is:" +youngestFriend);
        Console.WriteLine("the tallest friend is:" +tallestFriend);
    }
}

