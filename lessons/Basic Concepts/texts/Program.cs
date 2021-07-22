using System;

public class Program
{
	public static void Main()
	{
		int num = 60;
		Console.WriteLine(num); //output 60
		
		//To display a formatted string
		int two = 2;
		int four = 4;
		Console.WriteLine("two = {0}; four = {1}", two, four); // output two = 2; four = 4
		//Note: value of two is replaced by {0} and value of four is replaced by {1}

		//To print/output a text
        Console.WriteLine("Hello World!");
        Console.Write("Hello World");
        Console.Write("Hello World");
        //Note: Console.WriteLine() will print the input text and move to the next line after the first text input
        // console.Write() will print the input text and remain on the same line to output the next input text  
	}

}