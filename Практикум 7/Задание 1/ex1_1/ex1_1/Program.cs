using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            Console.Write("\nВведите символ для удаления: ");
            char x = Console.ReadLine().ToCharArray()[0];
            Console.WriteLine("\nРезультат: " + stringEdit(s, x).ToString());
            Console.ReadLine();
        }

        static StringBuilder stringEdit(StringBuilder s, char x)
        {
            for (int i = 0; i < s.Length;)
            {
                if (s[i] == x) s.Remove(i, 1);
                else i++;
            }
            return s;
        }

    }
}
