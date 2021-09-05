using System;
using System.Collections.Generic;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            // You are going to use multiplication by 3 as your example.
            // The program you are given takes N number as input. Write a program to output all numbers from 1 to N, replacing all numbers that are multiples of 3 by "*".

            int number = Convert.ToInt32(Console.ReadLine());
            
            //your code goes here
            for ( int i = 1; i <= number; i++ ) {
                if ( i % 3 == 0 ) {
                    Console.WriteLine("*");
                }else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}