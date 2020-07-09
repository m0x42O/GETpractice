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
            int m = 0, k = 0;
            try
            {
                Console.Write("Введите m = ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите k = ");
                k = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно.");
                Console.ReadKey();
            }
            int result = Calc(m) + Calc(2 * k);
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }

        static int Calc(int n, int a = 0)
        {
            if (n-- == 0) return a;
            return Calc(n, 1 + a + n);
        }
    }
}
