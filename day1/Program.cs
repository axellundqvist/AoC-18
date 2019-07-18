using System; 
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

// Axel Lundqvist
// AoC day 1 part 2
// 2019-07-18

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Axel\Desktop\learn_C#\advent_of_code\day01\input.txt");

            

            var hashset = new HashSet<int>();   // Create new hashset, only stores unique values.
            int current = 0;                    // Starting point, first value.


            string last = lines.Last();         // Get the last string in lines.
            int lastInt = int.Parse(last);      // Convert the last string to an int.

        Restart:                                // A goto point for restarting the loop.
            foreach (string line in lines)
            {
                int number = int.Parse(line);           // Convert each line to ints.
                int[] sumArray = { current, number };   // Create array with the current value and next input.
                current = sumArray.Sum();               // Current value is now the sum of those.

                if (!hashset.Add(current))              // If I can't add the current number in the hashset, its already in there.
                {
                    goto Found;                         // Skip to Found.
                }

                hashset.Add(current);                   // (else) Add that current number to the hashset.

                if (number.Equals(lastInt))             // If its the last iteration of the loop.
                {
                    goto Restart;                       // Goto restart, restarts the loop.
                }
            }


        Found:
            Console.WriteLine("Found first frequency! " + current);
            Console.ReadLine();
        }
    }
}