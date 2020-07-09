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
            int relevantMonth = DateTime.Now.Month;
            int m = 0;
            try
            {
                Console.Write("Введите сколько месяцев прошло с некоторой даты по настоящий день: ");
                m = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Write("Данные введены некорректно.");
                Console.ReadKey();
            }
            for (int i = m; i >= 0; i--)
            {
                if (relevantMonth.Equals(0))
                    relevantMonth = 12;
                relevantMonth--;
            }
            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.WriteLine("Название месяца некоторой даты - {0}.", months[(relevantMonth)]);
            Console.ReadKey();
        }
    }
}
