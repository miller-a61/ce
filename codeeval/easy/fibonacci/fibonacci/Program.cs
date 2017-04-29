﻿using System;
using System.Collections.Generic;
using System.IO;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        //static void Main()
        {

            //using (StreamReader sr = new StreamReader("test_file.txt"))

            //use for submission
            using (StreamReader sr = File.OpenText(args[0]))
            {
                int result;
                int i;
                string line;
                int outint;

                List<int> num = new List<int>();
                num.Add(0);
                num.Add(1);
                num.Add(2);

                for (i = 3; i < 46; i++)
                {
                    result = num[i - 1] + num[i - 2];
                    num.Add(result);
                }

                while ((line = sr.ReadLine()) != null)
                {
                    outint = int.Parse(line);

                    if (outint == 0 || outint == 1)
                    {
                        Console.WriteLine(outint);
                    }
                    else
                    {
                        Console.WriteLine(num[outint - 1]);
                    }
                }

                Console.ReadLine();
            }
        }
    }
}

/*
 * FIBONACCI SERIES
CHALLENGE DESCRIPTION:


The Fibonacci series is defined as: F(0) = 0; F(1) = 1; F(n) = F(n–1) + F(n–2) when n>1. 
Given an integer n≥0, print out the F(n).

INPUT SAMPLE:

The first argument will be a path to a filename containing integer numbers, one per line. E.g.

5
12
OUTPUT SAMPLE:

Print to stdout, the fibonacci number, F(n). E.g.

5
144

    */