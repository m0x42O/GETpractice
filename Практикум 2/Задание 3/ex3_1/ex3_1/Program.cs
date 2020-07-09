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
            int A=0, B=0;
            try
            {
                Console.Write("Введите A --> ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите B --> ");
                B = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно.");
                Console.ReadKey();
            }
            if (A <= B)
            {
                Console.WriteLine("Кубы всех целых чисел из данного диапазона в обратном порядке:");
                for (int i = B; i >= A; i--)
                    Console.Write(i * i * i + " ");
            }
            else
            {
                Console.WriteLine("Не соблюдается условие A <= B. Попробуйте снова.");
            }
            Console.ReadKey();
        }
    }
}
