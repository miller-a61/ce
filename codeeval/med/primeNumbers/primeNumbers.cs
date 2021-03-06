using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

class primeNumber
{
    static void Main(string[] args)
    {
        //using (StreamReader sr = new StreamReader("test_file.txt"))
        using (StreamReader sr = File.OpenText(args[0]))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                
                int length = Int32.Parse(line);

                var primes = getPrime(length);

                string outstring = "";

                foreach(int prime in primes)
                {
                    outstring = outstring + prime.ToString() + ',';
                }

                outstring = outstring.TrimEnd(',');
                Console.WriteLine(outstring);

            }

            Console.Read();
        }
    }

    private static List<int> getPrime(int number)
    {
        var prime = new List<int>();

        var sqrRoot = (int)Math.Sqrt(number);

        var isNotPrime = new BitArray(number + 1);

        for (int i = 2; i < number; ++i)
        {
            if (!isNotPrime[i])
            {
                prime.Add(i);

                if (i <= sqrRoot)
                {
                    for(int j = i * i; j < number; j+=i)
                    {
                        isNotPrime[j] = true;
                    }
                }
            }
        }

        return prime;

    }
}
