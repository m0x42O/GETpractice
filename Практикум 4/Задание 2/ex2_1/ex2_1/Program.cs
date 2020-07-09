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
            int a = 0, b = 0;
            try
            {
                Console.Write("Введите A: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите B: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно.");
                Console.ReadKey();
            }
            if (a < b)
            {
                while (a <= b)
                {
                    Recursion(a);
                    Console.WriteLine();
                    a++;
                }
            }
            else
            {
                Console.WriteLine("B должно быть БОЛЬШЕ A.");
            }
            Console.ReadKey();
        }

        static void Recursion(int n)
        {
            if (n!=0)
            {
                Recursion(n / 10);
                Console.Write(n % 10 + " ");
            }
        }
    }
}
