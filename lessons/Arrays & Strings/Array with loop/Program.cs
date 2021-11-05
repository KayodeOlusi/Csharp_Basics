using System;
					
public class Program
{
	public static void Main()
	{
		int[] newArray = new int[5];
		
		for(int i = 0; i < newArray.Length; i++) 
		{
			newArray[i] = i + 1;
			Console.WriteLine(newArray[i]);
		}
	}
}