using System;

public class Program
{
	public static void Main()
	{	
		int x = 100; 
		int b = 20;

        //if statement executes or runs a code if the condition inside the () is true. If false it executes the code inside the else {}

		if( x + b == 120 ) {
			Console.WriteLine("{0} + {1} is equal to 120", x, b);
		}else{
			Console.WriteLine("Wrong");
		}
        //output: 100 + 20 = 120
        //Remember: {0} and {1} are replaced by x and b	
	} 
}