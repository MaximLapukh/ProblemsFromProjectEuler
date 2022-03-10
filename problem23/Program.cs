using System;
using System.Collections.Generic;

namespace problem23
{
    class Program
    {
        public static List<int> DisPerfectNums = new List<int>();
        static void Main(string[] args)
        {
            for (int i = 1; i <= 28123; i++)
            {
                DisPerfectNums.Add(i);
            }
            GenerateSumOfPerfectNums();
            int answer = 0;
            foreach (var item in DisPerfectNums)
            {
                answer += item;
            }
            Console.WriteLine(answer);
        }
        public static void GenerateSumOfPerfectNums()
        {
            for (int i = 28123; i > 0; i--)
            {
                if (IsAbundentNum(i))
                {
                    DisPerfectNums.Remove(i * 2);
                }
            }
               
            
        }
        public static bool IsPerfectNum(int num)
        {
            int properDivisorsSum = 0;
            for (int i = 1; i < num-1; i++)
            {
                if (num % i == 0) properDivisorsSum += i;
            }
            if (properDivisorsSum == num) return true;
            return false;
            
        }
        public static bool IsAbundentNum(int num)
        {
            int properDivisorsSum = 0;
            for (int i = 1; i < num - 1; i++)
            {
                if (num % i == 0) properDivisorsSum += i;
            }
            if (properDivisorsSum >= num) return true;
            return false;

        }
    }
}
