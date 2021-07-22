using System;

public class Program
{
	public static void Main()
	{	 

        //Using Switch Statement, each value is called a case, and the variable being switched on is checked for each switch case
		int x = 3;
		switch(x)
		{
			case 1:
				Console.WriteLine("Not Found");
				break;
			case 2:
				Console.WriteLine("Close..");
				break;
			case 3:
				Console.WriteLine("Found!");
				break;
            default:
                Console.WriteLine("Try Again Later");
                break;
		}

        //Note: After every case we put a break; statement to end each case. Failure to add a break; statement will cause a compile error
        // The default case will run when all cases above do not match the reqired case
	} 
}