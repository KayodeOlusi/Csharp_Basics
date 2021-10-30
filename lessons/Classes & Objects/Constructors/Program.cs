using System;

public class Program 
{
    /*
        A class constructor is a special member method of a class that is executed whenever a new object of that class is created.
        A constructor has exactly the same name as its class, is public, and does not have any return type.
    */
    class Person
    {
        private int age;
        private string name;
        public Person(string nm)
        {
            name = nm;
        }
        public string getName()
        {
            return name;
        }
    }
    /*
        A default constructor has no parameters. However, when needed, parameters can be added to a constructor. This makes it possible to assign an initial value to an object when it's created
        Constructors can be overloaded like any method by using different numbers of parameters.
    */
    static void Main()
    {
        Person p = new Person("David");
        Console.WriteLine(p.getName()); // David
    }
}