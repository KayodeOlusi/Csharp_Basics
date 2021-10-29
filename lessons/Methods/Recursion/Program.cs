using System;
					
public class Program
{
	public static void Main()
	{
		// A recursive function is a function that calls itself
        Console.WriteLine(Fact(6));
	}

    static int Fact(int num)
     {
        if (num == 1)
        {
            return 1;
        }
        return num * Fact(num - 1);
    }
}