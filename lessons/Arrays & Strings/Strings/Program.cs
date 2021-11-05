using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
					
public class Program
{
	public static void Main()
	{
        /*
         In reality, strings in C# are objects. When you declare a string variable, you basically instantiate an object of type String.
        */
		    string a = "some text";

            Console.WriteLine(a.Length); //Outputs 9
            Console.WriteLine(a.IndexOf('t')); //Outputs 5

            a = a.Insert(0, "This is ");
            Console.WriteLine(a); //Outputs "This is some text"

            a = a.Replace("This is", "I am");
            Console.WriteLine(a);  //Outputs "I am some text"

            if(a.Contains("some"))
                Console.WriteLine("found");  //Outputs "found"

            a = a.Remove(4);
            Console.WriteLine(a);  //Outputs "I am"

            a = a.Substring(2);
            Console.WriteLine(a); //Outputs "am"

            /*
                a program that will take a string, replace all occurrences of the word "dog" with "cat" and output the first sentence only.
            */

            string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";
            text = text.Replace("dog", "cat");
            text = text.Substring(0, text.IndexOf(".") + 1);
            
            Console.WriteLine(text);
	}
}