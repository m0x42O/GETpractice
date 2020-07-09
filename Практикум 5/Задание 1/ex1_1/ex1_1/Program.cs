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
            double a = 0, b = 0, h = 0;
            try
            {
                Console.Write("Введите a = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите h = ");
                h = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно.");
                Console.ReadKey();
            }
            if (h > 0)
            {
                for(double i = a; i < b; i += h)
                {
                    try
                    {
                        Console.WriteLine("f({0}) = {1}", i, f(i));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("f({0}) = {1}", i, e.Message);

                    }
                }
            }
            else
            {
                Console.WriteLine("Параметр h введен некорректно.");
            }
            Console.ReadKey();
        }

        static double f(double x)
        {
            if (x == -1)
            {
                throw new Exception("Функция не определена.");
            }
            return (3 * x + 4) / (Math.Sqrt(x * x + 2 * x + 1));
        }
    }
}
