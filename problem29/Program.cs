using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace problem29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int index = 1;
            var distinctTerms = GenerateDistinctTerms();
            Console.WriteLine("Total Distinct Terms: {0}",distinctTerms.Count);
       
        }
        public static List<BigInteger> GenerateDistinctTerms()
        {
            var res = new List<BigInteger>();

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    res.Add((BigInteger)Math.Pow(i, j));
                }
            }
            res.Sort();
            return res.Distinct().ToList();
        }
    }
}
