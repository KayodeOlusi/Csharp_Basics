using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        /* Passing the first level of a video game awards the player 1 point. For each subsequent level passed, the points awarded increment by 1 (2 for the 2nd level, 3 for the 3rd, and so on).
        The program you are given takes the number of passed levels as input. Complete the given function to take that number as an argument, and recursively calculate and return the total number of points given for all passed levels.

         Sample Input : 3
         Sample Output : 6
        */
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        
        static int Points(int levels)
        {
            //your code goes here
            if(levels == 1)
            {
                return 1;
            }

            return levels + Points(levels - 1);
        }
    }
}