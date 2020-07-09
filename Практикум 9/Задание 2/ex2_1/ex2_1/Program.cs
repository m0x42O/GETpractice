using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filename = "chars.txt";
            string[] lines = File.ReadAllLines(filename);
            Console.WriteLine(String.Join("\n", lines));
            Console.Write("\nВведите k1 = ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите k2 = ");
            int k2 = Convert.ToInt32(Console.ReadLine());
            lines = linesModify(lines, k1, k2);
            Console.WriteLine(String.Join("\n", lines));
            Console.ReadKey();
        }

        static string stringModify(string s, int k1, int k2)
        {
            if (s.Length < k1) return "";
            if (s.Length < k2) return s.Substring(k1);
            return s.Substring(k1, k2 - k1 + 1);
        }

        static string[] linesModify(string[] lines, int k1, int k2)
        {
            return lines
                    .Select(str => stringModify(str, k1, k2))
                    .ToArray();
        }
    }
}
