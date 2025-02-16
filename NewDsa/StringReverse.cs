namespace NewDsa
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();

            string reversedString = ReverseString(input);
            Console.WriteLine("Reversed string: " + reversedString);
        }

        static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            int length = sb.Length;

            for (int i = 0; i < length / 2; i++)
            {
                char temp = sb[i];
                sb[i] = sb[length - i - 1];
                sb[length - i - 1] = temp;
            }

            return sb.ToString();
        }
    }

}
