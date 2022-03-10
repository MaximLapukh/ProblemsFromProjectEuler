using System;
using System.Collections.Generic;
using System.Linq;

namespace problem24
{
    class Program
    {
        public static List<long> GlobalNums = new List<long>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GenerateLexicographicOrderNums();
            Console.WriteLine(GlobalNums[1000000-1]);
        }
        public static void GenerateLexicographicOrderNums()
        {

            GenerateLexicographicOrderNums("", new List<int>() { 0,1,2,3,4,5,6,7,8,9});
        }
        public static void GenerateLexicographicOrderNums(string permut, List<int> remains)
        {            
            if(remains.Count == 2)
            {
                GlobalNums.Add(long.Parse($"{permut}{remains[0]}{remains[1]}")); 
                GlobalNums.Add(long.Parse($"{permut}{remains[1]}{remains[0]}"));
            }
            else
            {
                foreach (var num in remains)
                {
                    List<int> nextRemains = remains.ToList();
                    nextRemains.Remove(num);
                    GenerateLexicographicOrderNums(permut + num.ToString(), nextRemains);
                }
            }
        }
    }
}
