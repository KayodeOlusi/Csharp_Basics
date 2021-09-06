using System;
					
public class Program
{

    //There are three ways to pass arguments to a method when the method is called: By value, By reference, and as Output.
    // By value copies the argument's value into the method's formal parameter. Here, we can make changes to the parameter within the method without having any effect on the argument.

	static void Pow( /* ref int x */ int x /* out int x, out int y */) {
		x = x * x;
        //x = 5;
        //y = 42;
  }
 	
	public static void Main(string[] args)
	{
		int a = 3;
        //Pass by reference copies an argument's memory address into the formal parameter.
        //To pass the value by reference, the ref keyword is used in both the call and the method definition

        //Output parameters are similar to reference parameters, except that they transfer data out of the method rather than accept data in. They are defined using the out keyword.

		Pow( /* ref a */ );
        Pow( /* out a, out b*/ ); //Now a = 5 and y = 42;
        Pow( a );
		Console.WriteLine(a);
	}
}