using System;
					
public class Program
{
    // Parameters are variables that accept the values passed into the method when called
    //You can have more than one parameter

	static void theNum(int x , int y ) {
		int result = x / 2;
        int add = x + y;
		Console.WriteLine(result);
        Console.WriteLine(add);
	}
	
	public static void Main(string[] args)
	{
        // You can pass different arguments to the same method as long as they are of the expected type.
		theNum(42 , 12);
        theNum(32 , 12);
        theNum(16, 13);
	}
}