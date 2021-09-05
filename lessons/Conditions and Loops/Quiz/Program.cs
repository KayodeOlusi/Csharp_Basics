using System;
					
public class Program
{
	public static void Main()
	{
        //This program adds two user input numbers continuoslly. When the user inputs "exit", the addition stops. 
		do 
		{
			Console.WriteLine(" x =  ");
			string str = Console.ReadLine();
			if ( str == "exit")
			break;
			int x = Convert.ToInt32(str);
			
			Console.WriteLine(" y =  ");
			int y = Convert.ToInt32(Console.ReadLine());
			
			int sum = x + y;
			Console.WriteLine("Result : {0}", sum);
		} while ( true );
	}
}