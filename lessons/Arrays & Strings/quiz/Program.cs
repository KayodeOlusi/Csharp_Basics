using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        /*
            The program you are given defines an array with 10 words and takes a letter as input.
            Write a program to iterate through the array and output words containing the taken letter.
            If there is no such word, the program should output "No match".
        */
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();
            int count = 0;
            
            //your code goes here
            for(int i = 0; i < words.Length; i++)
            {
                if(words[i].Contains(letter))
                {
                    Console.WriteLine(words[i]);
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No match");
            }

            // using foreach
            foreach(string item in words)
            {
                if(item.Contains(letter))
                {
                    Console.WriteLine(item);
                    count++;
                }
            } 
            if(count == 0)
            {
                Console.WriteLine("No match");
            }
        }
    }
}