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
                string[] lists = line.Split(';');
                string[] first = lists[0].Split(',');
                string[] second = lists[1].Split(',');

                string outString = "";

                for (int i = 0; i < first.Length; i++)
                {
                    for (int j = 0; j < second.Length; j++)
                    {
                        if (first[i] == second[j])
                        {
                            outString = outString + first[i] + ",";
                        }
                    }
                }

                outString = outString.TrimEnd(',');

                Console.WriteLine(outString);
            }
        }
        Console.Read();
    }
}

/* SET INTERSECTION
CHALLENGE DESCRIPTION:


You are given two sorted list of numbers (ascending order). The lists themselves are comma delimited and the two lists are semicolon delimited. Print out the intersection of these two sets.

INPUT SAMPLE:

File containing two lists of ascending order sorted integers, comma delimited, one per line. E.g. 
1,2,3,4;4,5,6
20,21,22;45,46,47
7,8,9;8,9,10,11,12
OUTPUT SAMPLE:

Print out the ascending order sorted intersection of the two lists, one per line. Print empty new line in case the lists have no intersection. E.g. 
4

8,9
*/
