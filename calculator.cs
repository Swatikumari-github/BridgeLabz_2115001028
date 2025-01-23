using System;
class Calc{
   static void calculator(int a,int b)
   {
      Console.WriteLine("enter an operator:");
	  string op=Console.ReadLine();
	  switch(op)
	  {
	     case "+":
		    Console.WriteLine("number after addition:" +(a+b));
			break;
		  case "-":
		    Console.WriteLine("number after subtraction:" +(a-b));
			break;
		  case "*":
		    Console.WriteLine("number after multiplication:" +(a*b));
			break;
		   case "/":
		   if(b!=0){
		    Console.WriteLine("number after division:" +(a/b));
			}
			else{
			Console.WriteLine("division by 0 error");
			}
			break;
			default:
			Console.WriteLine("invalid operator");
			break;
		}
	}
	 static void Main(String [] args)
	 { 
	    Console.WriteLine("enter the number1");
	    int a=int.Parse(Console.ReadLine());
		Console.WriteLine("enter the number2");
	    int b=int.Parse(Console.ReadLine());
		calculator(a,b);
		Console.ReadLine();
		}
	}
	
