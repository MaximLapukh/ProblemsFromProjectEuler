using System;
using System.Collections.Generic;
using System.Linq;

namespace problem28
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("Answer:{0}", SumNumbersOfDiagonalsSquare1001());
		}
		public static int SumNumbersOfDiagonalsSquare1001()
		{
			int result = 1;
			int curNum = 2;
			for (int lenghtCycle = 1; lenghtCycle <= 999; lenghtCycle+=2)
			{           
				for (int i = 0; i < 4; i++)
				{
					int clength = lenghtCycle;
					while (clength > 0)
					{
						curNum++;
						clength--;               
					}
					result += curNum;
					curNum++;
				}
			}
			return result;
		}
	}
}
