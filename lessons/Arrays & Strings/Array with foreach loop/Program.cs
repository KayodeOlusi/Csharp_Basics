using System;
					
public class Program
{
	public static void Main()
	{
		int[] newArray = new int[5];
		
		for( int i = 0; i < newArray.Length; i++ ) 
		{
			newArray[i] = i + 1;
		}
		foreach( int i in newArray )
		{
			Console.WriteLine(i);
		}


        /*
            int[] newArray = { 1, 2, 3, 4, 5 };
		
		    foreach( int i in newArray )
		    {
			    Console.WriteLine(i); // 1, 2, 3, 4, 5
		    }
        */
	}
}