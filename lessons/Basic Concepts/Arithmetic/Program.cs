using System;
public class Program
{
	public static void Main()
	{	
		//Arithmetic Operations
		int x = 2;
		int y = 3;
		Console.WriteLine(x+y); //5 Addition
		Console.WriteLine(x-y); //-1 Subtraction
		Console.WriteLine(x*y); //6 Multiplication
		Console.WriteLine(y/x); //1 Division
		Console.WriteLine(y%x); //1 Remainder

		int a = 50;
		a+=2; // equivalent to a = a + 2
		a-=2; // equivalent to a = a - 2
		a/=2; // equivalent to a = a / 2
		a*=2; // equivalent to a = a * 2
		a%=2; // equivalent to a = a % 2

		int b = 5;
		b++; //equivalent to x = x + 1

		int c = 5;
		int d = c++;
		// c = 6, d = 5 { "++" as a postfix assigns the value of c to d and increments c and is the incremented value } 

		int e = 5;
		int f = ++e;
		// e = 6, f = 6 { "++" as a prefix increments e first and assign it to both values }

		//Same thing applies to "--" decrement e.g x-- or --x
	} 
}