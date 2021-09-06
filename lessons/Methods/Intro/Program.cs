using System;
					
public class Program
{
    // A method is a group of statements that perform a particular task.
    // In addition to the C# built-in methods, you may also define your own.
    //To use a method, you need to declare the method and then call it.

    // static void SayHi() {
    //     Console.WriteLine("Hello");
    // }

	static void sayHi() {
		Console.WriteLine("Hello");
	}
	
	public static void Main(string[] args)
	{
		sayHi();
        //You can call a method multiple times
	}
}