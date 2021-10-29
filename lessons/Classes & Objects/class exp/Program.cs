using System;
					
public class Program
{

    /* A class is a data type that defines a set of variables and methods for a declared object. An object is a concrete entity based on a class, and is sometimes referred to as an instance of a class.
    The code above declares a class named Person, which has age and name fields as well as a SayHi method that displays a greeting to the screen.
    You can include an access modifier for fields and methods (also called members) of a class. Access modifiers are keywords used to specify the accessibility of a member.
    A member that has been defined public can be accessed from outside the class, as long as it's anywhere within the scope of the class object. That is why our SayHi method is declared public, as we are going to call it from outside of the class.
    */
	 class Person
	{
 		 int age;
  		 string name;
 		 public void SayHi()
  		{
    		Console.WriteLine("Hi");
  		}
	}
	
	static void Main()
	{
		Person p1 = new Person();
		p1.SayHi();
	}
}