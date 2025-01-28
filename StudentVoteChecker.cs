using System;
class StudentVoteChecker

{
      public static bool CanStudentVote(int ages) {
        if (ages < 0) {
            return false; // Invalid age
        }
        return ages >= 18; // Eligible if age is 18 or above
    }
     
   static void Main(string [] args)
   {
      Console.WriteLine("enter the age");
	  int []ages=new int[10];
	   for (int i = 0; i < ages.Length; i++) {
          Console.WriteLine("Enter the age of student " + (i + 1) + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }
		
        for (int i = 0; i < ages.Length; i++) {
            bool canVote = CanStudentVote(ages[i]);
            if (ages[i] < 0) {
               Console.WriteLine("Student " + (i + 1) + " has an invalid age and cannot vote.");
            } else {
                Console.WriteLine("Student " + (i + 1) + (canVote ? " can vote." : " cannot vote."));
            }
        }
        Console.ReadLine();
	  
   }
}