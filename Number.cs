using System;
class Program{
   static void Numbers(int []num)
   {
      for(int i=0;i<5;i++){
	   if(num[i]==0){
	   Console.WriteLine("the number is 0");
	   }
	   else if(num[i]<0)
	   {
	   Console.WriteLine("the number is a negatibe number");
	   }
	   else{
	    if(num[i]%2==0){
		Console.WriteLine("The" +" " +num[i] +" is a positive number and it is even");
		}
		else{
		   Console.WriteLine("The" +" " +num[i] +" is a positive number and it is odd");
		  }
		}
	  }
	  if(num[0]==num[4]){
	  Console.WriteLine("both the numbers are equal");
	  }
	  else if(num[0]<num[4])
	  {
	  Console.WriteLine("number at index 0 is less than number at last index");
	  }
	  else{
	   Console.WriteLine("number at index 0 is greater than number at last index");
	   }
	}
	static void Main(string [] args)
	{
	  int []num=new int[5];
	  Console.WriteLine("enter the number");
	  for(int i=0;i<5;i++)
	  {
	     num[i]=Convert.ToInt32(Console.ReadLine());
	   }
	   Numbers(num);
	  }
	 }