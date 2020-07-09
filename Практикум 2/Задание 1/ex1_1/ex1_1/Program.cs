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
            double x, y;
            try
            {
                Console.Write("Введите x -> ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите y -> ");
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Возникла ошибка в вычислениях. Попробуйте снова.");
                Console.ReadKey();
                return;
            }
            double sum = x * x + y * y;
            double r1 = 9, r2 = 49;
            if (sum > r1 && sum < r2) 
            {
                Console.WriteLine("Точка лежит внутри заштрихованной области.");
            }
            else if (sum == r1 || sum == r2)
            {
                Console.WriteLine("Точка лежит на границе заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка лежит вне заштрихованной области.");
            }
            Console.ReadKey();
        }
    }
}
