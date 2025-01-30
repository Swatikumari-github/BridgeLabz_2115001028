using System;

class GuessingGame
{
   static Random random = new Random();

    static int GenerateGuess(int low, int high)
    {
        return random.Next(low, high + 1);
    }

    static char GetFeedback()
    {
        while (true)
        {
            Console.Write("Is my guess too high (H), too low (L), or correct (C)? ");
            char feedback = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (feedback == 'H' || feedback == 'L' || feedback == 'C')
            {
                return feedback;
            }
            Console.WriteLine("Invalid input. Please enter H, L, or C.");
        }
    }

    static void NumberGuessingGame()
    {
        Console.WriteLine("Think of a number between 1 and 100, and I will try to guess it!");
        Console.WriteLine("Press Enter when you are ready...");
        Console.ReadLine();

        int low = 1, high = 100, attempts = 0;
        int guess = GenerateGuess(low, high);

        while (true)
        {
            Console.WriteLine("My guess is: "+guess);
            attempts++;
            char feedback = GetFeedback();

            if (feedback == 'C')
            {
                Console.WriteLine("Hooray! I guessed your number in " +attempts +"attempts.");
                break;
            }
            else if (feedback == 'H')
            {
                high = guess - 1;
            }
            else if (feedback == 'L')
            {
                low = guess + 1;
            }

            if (low > high)
            {
                Console.WriteLine("Hmm, something seems off. Did you change your number?");
                break;
            }

            guess = GenerateGuess(low, high);
        }
    }

  static void Main(string [] args)
 {
    NumberGuessingGame();
	Console.ReadKey();
 }
 }