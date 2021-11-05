using System;
					
public class Program
{
	public static void Main()
	{
		// A jagged array is an array whose elements are arrays.

        int[ ][ ] jaggedArr = new int[3][ ]; 
        // a declaration of a single-dimensional array that has three elements, each of which is a single-dimensional array of integers. Each dimension is an array, so you can also initialize the array upon declaration like this

        int[ ][ ] jaggedArrs = new int[ ][ ] 
        {
            new int[ ] { 1, 8, 2, 7, 9 },
            new int[ ] { 2, 4, 6 },
            new int[ ] { 33, 42 }
        };
        Console.WriteLine(jaggedArrs[2][1]); // 42
	}
}