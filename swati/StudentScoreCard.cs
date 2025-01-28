using System;

class StudentScoreCard
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        int[,] scores = GenerateRandomScores(numStudents);
        double[,] results = CalculateResults(scores);

        DisplayScoreCard(scores, results);
    }

    static int[,] GenerateRandomScores(int numStudents)
    {
        Random rand = new Random();
        int[,] scores = new int[numStudents, 3]; // 3 subjects: Physics, Chemistry, Maths

        for (int i = 0; i < numStudents; i++)
        {
            scores[i, 0] = rand.Next(40, 101); // Physics
            scores[i, 1] = rand.Next(40, 101); // Chemistry
            scores[i, 2] = rand.Next(40, 101); // Maths
        }

        return scores;
    }

    static double[,] CalculateResults(int[,] scores)
    {
        int numStudents = scores.GetLength(0);
        double[,] results = new double[numStudents, 3]; // Total, Average, Percentage

        for (int i = 0; i < numStudents; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;

            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }

        return results;
    }

    static void DisplayScoreCard(int[,] scores, double[,] results)
    {
        Console.WriteLine("\nScorecard:\n");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.Write(i + 1 + "\t\t" + scores[i, 0] + "\t\t" + scores[i, 1] + "\t\t" + scores[i, 2] + "\t");
            Console.Write(results[i, 0] + "\t" + results[i, 1] + "\t" + results[i, 2] + "%\n");
        }
    }
}
