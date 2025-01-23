using System;
class ques13{
   static void NaturalSum()
   {
       Console.WriteLine("enter the number");
	   int num=Convert.ToInt32(Console.ReadLine());
	   int sum=0;
	   int LoopSum=0;
	   if(num>0){
	   sum=num*(num+1)/2;
          for(int i=num;i>=1;i--){
		  
	      LoopSum=LoopSum+i;
	       num--;
	   }
	   }
	   if(sum==LoopSum){
	   Console.WriteLine("adding the natural Number:" +sum);
	   }
	   
		
	}
	static void Main(string [] args)
	{
	  
	  NaturalSum();
	  Console.ReadLine();
	 }
}
