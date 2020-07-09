using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ex1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();
            Console.WriteLine("\nРезультат: ");
            Console.WriteLine(strModify(s));
            Console.ReadLine();
        }

        static string strModify(string s)
        {
            string engSet = @"[abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ]+";
            return Regex.Replace(s, engSet, "...");
        }
    }
}
