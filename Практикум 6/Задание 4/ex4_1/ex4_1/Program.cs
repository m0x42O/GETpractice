using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_1
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
            int[][] arr = randomArr(n, n);
            Console.WriteLine("\nМассив: ");
            outputArr2(arr);
            int number = 0;
            try
            {
                Console.Write("\nВведите целое число: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно.");
                Console.ReadKey();
            }
            int[] result = calcNumbers(arr, number);
            Console.WriteLine("\nРезультат: ");
            outputArr1(result);
            Console.ReadKey();
        }

        static int[][] randomArr(int n, int m)
        {
            int[][] array = new int[n][];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    array[i][j] = rand.Next(0, 9);
                }
            }
            return array;
        }

        static void outputArr1(int[] array)
        {
            foreach (int n in array)
            {
                Console.Write("{0} ", n);
            }
        }

        static void outputArr2(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                outputArr1(array[i]);
                Console.WriteLine();
            }
        }

        static int[] calcNumbers(int[][] array, int number)
        {
            int[] result = new int[array.GetLength(0)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = findNumbers(array[i], number);
            }
            return result;
        }

        static int findNumbers(int[] array, int number)
        {
            int result = 0;
            foreach (int n in array)
            {
                if (n > number) result++;
            }
            return result;
        }
    }
}
