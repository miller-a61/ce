﻿using System;
using System.IO;
class program
{
    static void Main(string[] args)
    {
        //using (StreamReader sr = new StreamReader("test_file.txt"))
        using (StreamReader sr = File.OpenText(args[0]))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(' ');

                string outstring = "";

                int i;

                for (i = 0; i < words.Length; i++)
                {
                    char last = words[i][words[i].Length - 1];
                    char first = words[i][0];
                    string middle = words[i].Substring(1, words[i].Length - 2);

                    if (i < words.Length -1)
                    {
                        outstring = last + middle + first + " ";
                    }
                    else
                    {
                        outstring = last + middle + first;
                    }

                    Console.Write(outstring);
                }
               Console.WriteLine();
            }
        }
        //Console.Read();
    }
}



/*VIEW ALL CHALLENGES
SWAP NUMBERS
CHALLENGE DESCRIPTION:

Write a program that, given a sentence where each word has a single digit positive integer as a prefix and suffix, swaps the numbers while retaining the word in between. Words in the sentence are delimited from each other by a space.

INPUT SAMPLE:

The first argument is a path to a file. Each line of the input file contains one test case represented by a sentence. Each word in the sentence begins and ends with a single digit positive integer i.e. 0 through 9. Assume all characters are ASCII.



1
2
4Always0 5look8 4on9 7the2 4bright8 9side7 3of8 5life5
5Nobody5 7expects3 5the4 6Spanish4 9inquisition0
OUTPUT SAMPLE:

For each test case, print to standard output the sentence obtained by swapping the numbers surrounding each word, one per line.



1
2
0Always4 8look5 9on4 2the7 8bright4 7side9 8of3 5life5
5Nobody5 3expects7 4the5 4Spanish6 0inquisition9
CONSTRAINTS:

The suffix and the prefix of each word may be equal.
Sentences are form 1 to 17 words long.
The number of test cases is 40.
SUBMIT SOLUTION
*/
