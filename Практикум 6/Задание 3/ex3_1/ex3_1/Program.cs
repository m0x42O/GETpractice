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
            int n = 0;
            try
            {
                Console.WriteLine("Введите размер массива: ");
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно.");
                Console.ReadKey();
            }
            int[,] arr = randomArr(n, n);
            Console.WriteLine("Исходный массив: ");
            Output(arr);
            Modify(arr);
            Console.WriteLine("Измененный массив: ");
            Output(arr);
            Console.ReadKey();
        }

        static int[,] randomArr(int n, int m)
        {
            int[,] array = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 9);
                }
            }
            return array;
        }

        static int[,] Modify(int[,] array)
        {
            if (array.GetLength(0) % 2 == 0)
            {
                for (int i = 0; i < array.GetLength(0); i += 2)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        int buffer = array[i, j];
                        array[i, j] = array[i + 1, j];
                        array[i + 1, j] = buffer;
                    }
                }
            }

            return array;
        }

        static void Output(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
