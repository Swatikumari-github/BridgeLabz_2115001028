using System;

class Program
{
    static void AverageMark()
    {
         Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());
		 double[,] marks = new double[numStudents, 3]; 
        double[] percentages = new double[numStudents]; 
        string[] grades = new string[numStudents];
		  for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nStudent" +(i + 1));

            // Input marks for Physics, Chemistry, and Maths
            for (int j = 0; j < 3; j++)
            {
                double subjectMarks;
                string subjectName = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";
                do
                {
                    Console.Write("Enter marks for" +(subjectName));
                    subjectMarks = double.Parse(Console.ReadLine());
                    if (subjectMarks < 0)
                    {
                        Console.WriteLine("Marks cannot be negative. Please enter a positive value.");
                    }
                } while (subjectMarks < 0);

                marks[i, j] = subjectMarks;
            }

            // Calculate the percentage
            double totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (totalMarks / 300) * 100; // Assuming full marks are 100 for each subject

            // Calculate grade based on percentage
            if (percentages[i] >= 90)
                grades[i] = "A+";
            else if (percentages[i] >= 80)
                grades[i] = "A";
            else if (percentages[i] >= 70)
                grades[i] = "B+";
            else if (percentages[i] >= 60)
                grades[i] = "B";
            else if (percentages[i] >= 50)
                grades[i] = "C";
            else
                grades[i] = "F"; // Fail grade
        }

        // Display the results for all students
        Console.WriteLine("\nDetails of each student:");
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("Student | Physics | Chemistry | Maths | Percentage | Grade");
        Console.WriteLine("----------------------------------------------------------");

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("{0,7} | {1,7:F2} | {2,9:F2} | {3,5:F2} | {4,10:F2} | {5,5}",
                              i + 1, marks[i, 0], marks[i, 1], marks[i, 2], percentages[i], grades[i]);
        }
    }

    static void Main(string[] args)
    {
       AverageMark();
    }
}
