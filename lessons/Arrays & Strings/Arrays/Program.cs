using System;
			
public class Program
{

    /*An array is a data structure that is used to store a collection of data. You can think of it as a collection of variables of the same type.*/
	public static void Main()
	{
        int[ ] myArray; // To declare a new array

        /*
            Since arrays are objects, we need to instantiate them with the new keyword
            This instantiates an array named myArray that holds 5 integers.
        */
        int[ ] anotherArray = new int[5]; 

        /*
            After creating the array, you can assign values to individual elements by using the index numbe
        */
        myArray[0] = 23;

        /*
            We can provide initial values to the array when it is declared by using curly brackets:
        */
        string[ ] names = new string[3] {   "John", "Mary", "Jessica"  };
        double[ ] prices = new double[4] {  3.6, 9.8, 6.4, 5.9  };

        /*
            We can omit the size declaration and the 'new' keyword when the number of elements are provided in the curly braces
        */
        string[ ] name = { "John", "Mary", "Jessica" };
        double[ ] price = { 3.6, 9.8, 6.4, 5.9 };

	}
}