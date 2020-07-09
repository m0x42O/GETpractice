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
            int[] arr = Input();
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int max = Max(arr);
            int min = Min(arr);
            if (max > min)
                Console.WriteLine("Максимальный элемент встречается позже минимального. Попробуйте снова.");
            else
                Amount(arr, min, max);
            Console.ReadKey();
        }

        static int Max(int[] arr)
        {
            int index = 0;
            int max = arr[index];
            for(int i=1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            return index;
        }

        static int Min(int[] arr)
        {
            int index = 0;
            int min = arr[index];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            return index;
        }

        static void Amount(int[] arr, int min, int max)
        {
            int sum = 0;
            for(int i = max + 1; i < min; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("\nСумма элементов: {0}.", sum);
        }

        static int[] Input()
        {
            int n = 0;
            try
            {
                Console.Write("Введите размер одномерного массива: ");
                n = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно. Попробуйте снова.");
                Console.ReadKey();
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

    }
}
