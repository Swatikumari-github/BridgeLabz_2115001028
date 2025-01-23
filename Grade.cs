using System;
class Grading{
   static void Grade(float physics,float chemistry,float maths)
   {
        float avgMarks=(physics+chemistry+maths)/3;
		float percentage=avgMarks;
		if(percentage>80)
	    {
		 Console.WriteLine("the grade of the student is A");
		 Console.WriteLine("Level 4,above agency-normalized students standard");
		 Console.WriteLine(avgMarks);
		}
		else if(percentage>=70 && percentage<=79){
			Console.WriteLine("the grade of the student is B");
		 Console.WriteLine("Level 4,at agency-normalized students standard");
		 Console.WriteLine(avgMarks);
		}
		else if(percentage>=60 && percentage<=69){
		  Console.WriteLine("the grade of the student is C");
		 Console.WriteLine("Level 2 below,but approaching agency-normalized students standard");
		 Console.WriteLine(avgMarks);
		}
		else if(percentage>=50 && percentage<=59){
		  Console.WriteLine("the grade of the student is D");
		 Console.WriteLine("Level 1 below,well below agency-normalized students standard");
		 Console.WriteLine(avgMarks);
		}
		else if(percentage>=40 && percentage<=49){
		  Console.WriteLine("the grade of the student is E");
		 Console.WriteLine("Level 1-, too below agency-normalized students standard");
		 Console.WriteLine(avgMarks);
		}
		else{
			 Console.WriteLine("the grade of the student is R");
		 Console.WriteLine("Remedial Standards");
		 Console.WriteLine(avgMarks);
		}
		
	}
   
	static void Main(String [] args)
	{
	  Console.WriteLine("enter the marks of physics");
	  float physics=float.Parse(Console.ReadLine());
	  Console.WriteLine("enter the marks of chemistry");
	  float chemistry=float.Parse(Console.ReadLine());
	  Console.WriteLine("enter the marks of maths");
	  float maths=float.Parse(Console.ReadLine());
	  Grade(physics,chemistry,maths);
	  Console.ReadLine();
	 
	}
}