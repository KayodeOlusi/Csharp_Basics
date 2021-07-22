using System;
public class Program
{
	public static void Main()
	{	
		//To get user data/input we use Console.Readline() method
		string yourName;
		Console.WriteLine("What is your name?");
		yourName = Console.ReadLine(); // Assigned the user input to a variable called yourName
		Console.WriteLine("Hello {0}", yourName);

        //To convert user data to other data types we use Convert.ToXXX where XXX is the data type we want to convert to
		int age = Convert.ToInt32(Console.ReadLine()); //Convert the inputed number {data} of the user to  base32
		Console.WriteLine("You are {0} years old", age);
	}
}