using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Axel Lundqvist
// AoC day 2, part 1 & 2
// 2019-07-19

namespace AoC_day02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Axel\Desktop\learn_C#\advent_of_code\AoC_day02\input.txt");

            int countDuplicates = 0;                        // Keep count of duplicates and triplets.
            int countTriplets = 0;

            foreach (string line in lines)
            {
                foreach (char c in line)                    // Foreach char in current line.
                {
                    if (line.Count(x => x == c) == 2)       // If any char appears twice
                    {
                        countDuplicates++;                  // Count of duplicates goes up.
                        goto CheckForTriplets;              // Skip to CheckForTriplets.
                    }
                }
            CheckForTriplets:
                foreach (char c in line)
                {
                    if (line.Count(x => x == c) == 3)       // If any char appears three times.
                    {
                        countTriplets++;                    // Count of triplets goes up.
                        break;
                    }
                }
            }

            int answer = countDuplicates * countTriplets;   // First answer, duplicates * triplets.
            Console.WriteLine(answer);


            // Part 2


            List<string> MatchingStrings = new List<string>();  // Is going to store the matching strings.

            int length = lines[0].Length;                       // line length, for further use.
            int targetLength = length - 1;                      // The length I'm looking for.

            foreach (string line in lines)
            {
                foreach (string checkLine in lines)
                {
                    int sameCharAtIndex = 0;                // Store number of times the chars was identical at same index.

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == checkLine[i])        // If both chars at the same index is the same.
                        {
                            sameCharAtIndex++;              // Add to sameCharAtIndex.
                        }
                    }
                    if (sameCharAtIndex == targetLength)    // If sameCharAtIndex reaches targetLength (line - 1).
                    {
                        MatchingStrings.Add(line);          // Add the matching strings to MatchingStrings.
                        MatchingStrings.Add(checkLine);
                        goto RemoveDifference;
                    }
                }
            }

        RemoveDifference:
            string first = MatchingStrings[0];
            string second = MatchingStrings[1];
            string answerPart2 = "";

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])                  // If the chars in the same indexes are the same, add that char to answer string.
                {
                    answerPart2 = answerPart2 + first[i];
                }
            }

            Console.WriteLine(answerPart2);

            Console.ReadLine();

        }
    }
}
