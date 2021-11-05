using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
					
public class Program
{
	public static void Main()
	{
        // The Array class in C# provides various properties and methods to work with arrays.

		int[] a = { 2, 3, 4 };

		Console.WriteLine(a.Rank); // returns the number of dimensions of the array : 1
		Console.WriteLine(a.Length); //  returns the number of elements : 3
        Console.WriteLine(a.Sum()); // returns the sum of all elements in the array 
        Console.WriteLine(a.Max()); // returns the largest value : 4
        Console.WriteLine(a.Min()); // returns the smallest value : 2
	}
}