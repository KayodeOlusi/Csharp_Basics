using System;

public class Program 
{
    /*
        A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can be used as if they are public data members, but they actually include special methods called accessors. Accessor declarations can include a get accessor, a set accessor, or both.
    */

    class Person
        {
            // A property can also be private, so it can be called only from within the class.

            /* When you do not need any custom logic, C# provides a fast and effective mechanism for declaring private members through their properties.  Name is called an auto-implemented property. Also called auto-properties, 
            they allow for easy and short declaration of private members.
            
             public string Name { get; set; } 
             
             */
            private string name; // field
            public string Name // property
            {
                get { return name; }
                set { name = value; }
            }
        }
        static void Main(string[] args)
        {
            // The property is accessed by its name, just like any other public member of the class.
            Person p = new Person();
            p.Name = "Bob";
            Console.WriteLine(p.Name); // Bob
        }
}