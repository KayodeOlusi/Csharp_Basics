using System;
					
public class Program
{
	public static void Main()
	{
        // Drawing a Pyramid with parameter of DrawPyramid determining the number of rows
		DrawPyramid(5);
	}
	
	static void DrawPyramid(int n)
	{
		for(int i = 1; i <= n; i++)
		{
			for(int j = 1; j <= n; j++)
			{
				Console.WriteLine("");
			}
			for(int k = 1; k <= (2 * i) - 1; k++)
			{
				Console.WriteLine("*" + "");
			}
			
			Console.WriteLine();
		}
	}
}