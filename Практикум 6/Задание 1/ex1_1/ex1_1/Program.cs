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
            int a1 = 0, b1 = 0;
            string[] array1 = { "" };
            Console.WriteLine("Одномерный массив.");
            try
            {
                Console.Write("Введите элементы массива через пробел: ");
                array1 = Console.ReadLine().Split(' ');
            }
            catch
            {
                Console.Write("Данные введены некорректно.");
            }
            try
            {
                Console.Write("Введите начало интервала: ");
                a1 = int.Parse(Console.ReadLine());
                Console.Write("Введите конец интервала: ");
                b1 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Данные введены некорректно.");
                Console.ReadKey();

            }
            Console.WriteLine("Сумма элементов интервала: {0}.", Sum1(array1, a1, b1));

            Console.WriteLine("Двумерный массив.");
            int n, m, a2 = 0, b2 = 0;
            int[,] array2 = Input(out n, out m);
            try
            {
                Console.Write("Введите начало интервала: ");
                a2 = int.Parse(Console.ReadLine());
                Console.Write("Введите конец интервала: ");
                b2 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Данные введены некорректно.");
                Console.ReadKey();

            }
            int Sum2 = 0;
            for (int i = a2; i < b2; i++)
                if (i >= m)
                {
                    Sum2 += array2[i / m, i % m];
                }
                else
                {
                    Sum2 += array2[0, i];
                }
            Console.WriteLine("Сумма элементов интервала: {0}.", Sum2);


            Console.ReadKey();
        }

        static int Sum1(string[] array1, int a, int b)
        {
            int h = 0, sum = 0;
            foreach (string str in array1)
            {
                h = Int32.Parse(str);
                if (h >= a && h <= b)
                    sum += h;
            }
            return sum;
        }

        static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("Введите размерность массива [n*m]:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0}*{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }
    }
}
