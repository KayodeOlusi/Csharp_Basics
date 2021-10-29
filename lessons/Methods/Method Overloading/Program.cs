using System;
					
public class Program
{
	public static void Main()
	{
		// Method overloading is when multiple methods have the same name, but different parameters.
        Print(4);
        Print(7.37);
        Print("Value :", 8.54);
	}

    static void Print(int a)
    {
        // The + operator is used to concatenate values. In this case, the value of a is joined to the text "Value: ".
        Console.WriteLine("Value: "+ a);
    }

    static void Print(double a)
    {
        // Overloading it will make it available for other types, such as double
        Console.WriteLine("Value: "+ a);
    }

    static void Print(string label, double a) 
    {
        Console.WriteLine(label + a);
    }   
}