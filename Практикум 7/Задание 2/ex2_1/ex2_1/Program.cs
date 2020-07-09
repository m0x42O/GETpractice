using System;
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
            Console.WriteLine("Введите сообщение: ");
            string s = Console.ReadLine();
            Console.WriteLine("\nВведите слово: ");
            string word = Console.ReadLine();
            Console.WriteLine("\nСлово [{0}] встречается {1} раз(а).", word, Quantity(s, word));
            Console.ReadLine();
        }

        static string deletePointing(string str)
        {
            StringBuilder strb = new StringBuilder(str);
            for (int i = 0; i < strb.Length;)
            {
                if (char.IsPunctuation(strb[i])) { strb.Remove(i, 1); }
                else { ++i; }
            }
            return strb.ToString();
        }

        static int Quantity(string str, string word)
        {
            int number = 0;
            str = deletePointing(str);
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (word == words[i]) number++;
            }
            return number;
        }

    }
}
