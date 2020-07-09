using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, h = 0;
            try
            {
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("h = ");
                h = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректно введены данные.");
                Console.ReadKey();
            }
            if (h > 0)
            {
                for(double i = a; i <= b; i++)
                {
                    Console.WriteLine("f({0}) = {1}.", i, f(i));
                }
                for (double i = a; i <= b; i += h)
                {
                    double y;
                    f(i, out y);
                    Console.WriteLine("f({0}) = {1}.", i, y);
                }
            }
            else { Console.WriteLine("Параметр h введен некорректно."); }
            Console.ReadKey();
        }

        static double f(double x)
        {
            double y;
            if (Math.Abs(x) <= 1)
            {
                y = Math.Pow(x, 2) - 1;
            }
            else if (Math.Abs(x) > 2)
            {
                y = Math.Pow(x, 5) - 1;
            }
            else y = 2 * x - 1;
            return y;
        }

        static void f(double x, out double y)
        {
            if (Math.Abs(x) <= 1)
            {
                y = Math.Pow(x, 2) - 1;
            }
            else if (Math.Abs(x) > 2)
            {
                y = Math.Pow(x, 5) - 1;
            }
            else y = 2 * x - 1;
        }
    }
}
