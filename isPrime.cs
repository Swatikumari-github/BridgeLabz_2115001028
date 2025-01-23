using System;
class prime{
   static void checkPrime(int number)
   {
         if(number<=1)
		 {
		   Console.WriteLine("the number is not a prime number");
		   return;
		   }
		   bool isPrime=true;
        for(int i=2;i<=Math.Sqrt(number);i++){
		if(number%i==0){
		  isPrime=false;
		    break;
		}
		}
		if(isPrime){
		Console.WriteLine("the given number" +number +" " +"is a prime number");
		}
		else{
		   Console.WriteLine("the given number" +number +" " +"is a prime number");
		 }
		  
		
	}
   
	static void Main(String [] args)
	{
	  Console.WriteLine("enter the number");
	  int number=Convert.ToInt32(Console.ReadLine());
	  checkPrime(number);
	  Console.ReadLine();
	 
	}
}