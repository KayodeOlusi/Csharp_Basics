using System;
					
public class Program
{
	public static void Main()
	{
		// An array can have multiple dimensions

        int[ , ] x = new int[ 3, 4 ]; // a two-dimensional 3x4 integer array:

        // We can initialize multidimensional arrays in the same way as single-dimensional arrays.

        int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} };  // This will create an array with three rows and two columns
        for (int k = 0; k < 3; k++)
         {
            for (int j = 0; j < 2; j++) 
            {
                Console.Write(someNums[ k, j ] + " " );
            }
                Console.WriteLine();
        } // a program that will display the values of the array in the form of a table.
	}
}