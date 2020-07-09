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
            Console.WriteLine("Введите двухзначное число, чтобы определить четность суммы цифр.");
            string str = Console.ReadLine();
            int result = Convert.ToInt32(str[0].ToString()) + Convert.ToInt32(str[1].ToString());
            if (result % 2 == 0)
            {
                Console.WriteLine("Сумма цифр числа {0} - четная.", str);
            }
            else
            {
                Console.WriteLine("Сумма цифр числа {0} - не четная.", str);
            }
            Console.ReadKey();
        }
    }
}
