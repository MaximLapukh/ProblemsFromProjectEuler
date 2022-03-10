using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace problem22
{
    class Program
    {
        static List<string> names = new List<string>();
        static int result = 0;
        static int numNames = 1;
        static void Main(string[] args)
        {
            using(var FS = new FileStream(@"D:\text.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[FS.Length];
                FS.Read(buffer, 0, buffer.Length);
                var data = Encoding.UTF8.GetString(buffer).Split(",");
                foreach (var name in data)
                {
                    var builder = new StringBuilder(name).Replace("\"", "");
                    names.Add(builder.ToString());
                }
                names.Sort();
                foreach (var name in names)
                {
                    int sum = 0;
                    for (int i = 0; i < name.Length ; i++)
                    {
                        sum += name[i] - 64;
                    }
                    result += sum * numNames++;
                }
                Console.WriteLine(result);
            }
        }
    }
}
