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
            double x=0;
            try
            {
                Console.Write("Введите x --> ");
                x = Convert.ToDouble(Console.ReadLine());
            }


            catch
            {
                Console.WriteLine("Данные введены некоррректно. Попробуйте снова.");
                Console.ReadKey();  
            }
            double sum = f(2, x) + f(4, x) + f(6, x);
            Console.WriteLine("Ответ: {0}.", sum);
            Console.ReadKey();
        }

        static double f(double n,double x)
        {
            return Math.Pow(x, n) / n;
        }
    }
}
