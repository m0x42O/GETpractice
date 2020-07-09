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
            int i, j;
            int num = 7;
            int d = 1;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < d; j++)
                {
                    Console.Write("{0} ", num);
                }
                d++;
                num--;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
