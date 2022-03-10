using System;
using System.Collections.Generic;
using System.Linq;

namespace problem39
{
    class Program
    {

        static void Main(string[] args)
        {
            var CombosRightTraingels = new Dictionary<int, int>();//perimeter - count of combos
            for (int p = 3; p <= 1000; p++)
            {
                 var combos =  GetCombos(p);
                if (combos.Count > 0) {
                    CombosRightTraingels.Add(p, combos.Count);
                }
            }
            //GetMax

        }

        private static List<List<int>> GetCombos(int p)
        {
            List<List<int>> res = new List<List<int>>();
            for (int a = 1; a < p; a++)
            {
                for (int b = 1; b < p - 1 - a; b++)
                {
                    var c = (p - a - b);
                    if (a + b >= c)
                        // Do the most number is hypotenuse?
                        if (IsPythagoreanTheorem(a, b, c) || IsPythagoreanTheorem(b, c, a) || IsPythagoreanTheorem(c, a, b))
                        {
                            var combo = new List<int>() { a, b, c };
                            //Max(a,b,c)
                            combo.Sort();
                            if (res.FirstOrDefault(c =>
                                c[0] == combo[0] && 
                                c[1] == combo[1] &&
                                c[2] == combo[2]) == null)
                            {
                                res.Add(combo);
                                Console.WriteLine($"({a}-{b}-{c}) - {p}");
                            }

                        }

                }
            }
            return res;
        }

        static private bool IsPythagoreanTheorem(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }
    }
}
