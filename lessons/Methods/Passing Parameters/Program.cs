using System;
					
public class Program
{

    //There are three ways to pass arguments to a method when the method is called: By value, By reference, and as Output.
    // By value copies the argument's value into the method's formal parameter. Here, we can make changes to the parameter within the method without having any effect on the argument.

	static void Pow( /* ref */ int x ) {
		x = x * x;
  }
 	
	public static void Main(string[] args)
	{
		int a = 3;
        //Pass by reference copies an argument's memory address into the formal parameter.
        //To pass the value by reference, the ref keyword is used in both the call and the method definition
		Pow( /*ref*/ a);
		Console.WriteLine(a);
	}
}