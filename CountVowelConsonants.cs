using System;
class VowelConsonants
{
   static void CountVowelConsonants()
   {
    Console.WriteLine("Enter the String");
	string s=Console.ReadLine().ToLower();
	int vowel=0;
	int consonants=0;
	foreach(char c in s)
	{
	  if(c=='a')
	  {
	    vowel++;
	  }
	  else if(c=='e')
	  {
	   vowel++;
	  }
	   else if(c=='i')
	  {
	   vowel++;
	  }
	   else if(c=='o')
	  {
	   vowel++;
	  }
	   else if(c=='u')
	  {
	   vowel++;
	  }
	  else
	  {
	  consonants++;
	  }
	}
	Console.WriteLine("the total number of vowel is: " +vowel);
	Console.WriteLine("the total number of consonants is: " +consonants);
	}
	
	
 static void Main(string [] args)
 {
  CountVowelConsonants();
  Console.ReadLine();
 }
}