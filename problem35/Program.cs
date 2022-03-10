using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace problem35
{
    class Program
    {
        static List<int> _CycleNums = new List<int>();
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(isPrimerNumberOptimize(91));
            Console.WriteLine(isPrimerNumberOptimize(91));
            Console.WriteLine(isPrimerNumberOptimize(91));
            _CycleNums.Add(2);
            for (int i = 3; i < 100; i++)
            {
               
                var cycleNums = GetCycleNumbes(i);
                var isCycleNums = true;
                foreach (var cycNum in cycleNums)
                {
                    if (!isPrimerNumberOptimize(cycNum))
                    {
                        isCycleNums = false;
                    }
                }
                if (isCycleNums)
                {
                    _CycleNums.AddRange(cycleNums);
                    Console.WriteLine(i);
                }
                    
            }
            _CycleNums = _CycleNums.Distinct().ToList();
            Console.WriteLine("Answer:"+_CycleNums.Count);
        }
        static BigInteger Pow(int x , int y)
        {
            BigInteger answer = x;
            for (int i = 1; i < y; i++)
            {
                answer = answer * x;
            }
            return answer;
        }
        static bool IsPrimeNumber(in int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        static bool isPrimerNumberOptimize(in int num)
        {        
            if(num != 1 && num %2 != 0)
            {
                var temp = rnd.Next(1, num - 1);
                temp = Math.Min(temp, 731);
                if (Pow(temp, num - 1) % num == 1){

                    temp = rnd.Next(1, num - 1);
                    temp = Math.Min(temp, 157);

                    if (Pow(temp, num - 1) % num == 1)
                    {

                        return true;
                    }
                }
                
            }
            return false;
        }
        static List<int> GetCycleNumbes(in int number)
        {
            var res = new List<int>();
            string num_str = number.ToString();
            for (int i = 0; i < number.ToString().Length; i++)
            {
                res.Add(int.Parse(num_str));
                var sym = num_str[0];
                num_str = num_str.Substring(1);
                num_str += sym;
            }
            return res;
        }
    }
}
