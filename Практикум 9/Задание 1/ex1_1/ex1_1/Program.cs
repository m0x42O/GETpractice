
using System;
using System.IO;
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
            string file = "arr.txt";
            int n = 0;
            try
            {
                Console.WriteLine("Введите количество вещественных чисел.");
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно.");
                Console.ReadKey();
            }
            double[] array = randomArr(n, -100,100);
            Console.WriteLine("\nМассив: ");
            outputArr(array);
            recordFile(array, file);
            Console.WriteLine("Массив записан в файл.");
            double a = 0, b = 0;
            try
            {
                Console.Write("\nВведите начало диапазона: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите конец диапазона: ");
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно.");
                Console.ReadKey();
            }
            array = readFile(file);
            Console.WriteLine("\nКомпоненты, не попадающие в данный диапазон: ");
            outputArr(arrayModify(array, a, b));
            Console.ReadLine();
        }

        static double[] randomArr(int n, double min, double max)
        {
            Random rand = new Random();
            double[] arr = new double[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = min + rand.NextDouble() * (max - min);
            }
            return arr;
        }

        static void outputArr(double[] arr)
        {
            foreach (double num in arr)
            {
                Console.WriteLine(num + " ");
            }
        }

        static void recordFile(double[] arr, string file)
        {
            FileStream f = new FileStream(file, FileMode.OpenOrCreate);
            BinaryWriter f1 = new BinaryWriter(f);
            foreach (double num in arr)
            {
                f1.Write(num);
            }
            f1.Close();
            f.Close();
        }

        static double[] readFile(string file)
        {
            FileStream f = new FileStream(file, FileMode.Open);
            BinaryReader f1 = new BinaryReader(f);
            double[] array = new double[f.Length / 8];
            for (int i = 0; i < f.Length; i += 8)
            {
                f.Seek(i, SeekOrigin.Begin);
                array[i / 8] = f1.ReadDouble();
            }
            f1.Close();
            f.Close();
            return array;
        }

        static double[] arrayModify(double[] arr, double a, double b)
        {
            return arr.Where(n => n < a || n > b).ToArray();
        }
    }
}
