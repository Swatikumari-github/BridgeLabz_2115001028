using System;
class ques8{
   static void DownCounter(int counter)
   {
        while(counter>=1){
		Console.WriteLine("the value of the counter is:" +counter);
	    counter--;
		
		}
		
	}
	static void Main(string [] args)
	{
	   Console.WriteLine("enter the value of  counter:");
	   int counter=Convert.ToInt32(Console.ReadLine());
DownCounter(counter);
	   Console.ReadLine();
	 }
}
