using System;
					
public class Program
{
    // When defining a method, you can specify a default value for optional parameters. Note that optional parameters must be defined after required parameters. If corresponding arguments are missing when the method is called, the method uses the default values.
	static int Pow( int x, int y=2 /* int a, int b */) {
		int result = 1;
        for ( int i = 0; i < y; i++ ) {
        result *= x;
        }

        //return a * b;
 
        return result;
	}
	
	public static void Main(string[] args)
	{
		Console.WriteLine(Pow(6)); //36

        // Named arguments use the name of the parameter followed by a colon and the value.
        // int res = Pow( a : 3, b : 5 )
        // Console.WriteLine(res)
	}
}