using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace problem55
{
    class Program
    {
        static int iteration = 0;
        static List<int> answer = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 10; i < 10000; i++)
            {
                if (isLychrelNumber(i)) answer.Add(i);
            }
            Console.WriteLine(answer.Count);
        }
        static BigInteger inverseNumber(BigInteger num)
        {
            var res = "";
            foreach (var sym in  num.ToString().Reverse())
            {
                res += sym;
            }            
            return BigInteger.Parse(res);
        }
        static bool isPalindrom(BigInteger num)
        {
            var temp = num.ToString();
            for (int i = 0; i < temp.Length / 2; i++)
            {
                if (temp[i] != temp[temp.Length - 1 - i]) return false;
            }
            return true;            
        }
        static bool isLychrelNumber(BigInteger num)
        {
            var next = num + inverseNumber(num);
            if (isPalindrom(next)) { 
                iteration = 0; 
                return false;
            }else
                if (iteration < 50)
                {
                    iteration++;
                    return isLychrelNumber(next);
                }
                else
                {
                    iteration = 0;
                    return true; 
                }            
        }
    }
}
