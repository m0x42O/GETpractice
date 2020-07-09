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
            double S = 0;
            try
            {
                Console.WriteLine("Введите площадь полной поверхности, чтобы найти ребро куба.");
                Console.Write("S = ");
                S = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно.");
                Console.ReadKey();
            }
            double a = Math.Sqrt(S / 6);
            Console.WriteLine("Ребро куба - {0}", a);
            Console.ReadKey();
        }
    }
}
