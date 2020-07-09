using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ex1_1
{
    class Program
    {
        class String
        {
            public String(int n)
            {
                length = n;
                str = new StringBuilder(length);
            }
            public String(string s, int len)
            {
                length = len;
                str = new StringBuilder(s.Substring(0, length));
            }
            public int SpacesQuantity()
            {
                return str.ToString().Count(x => x == ' ');
            }
            public void DeletePoints()
            {
                string s = str.ToString();
                str.Clear();
                str.Append(Regex.Replace(s, "[,.:?!]", ""));
                length = str.Length;
            }
            public int Length
            {
                get { return length; }
            }
            public override string ToString()
            {
                return str.ToString();
            }

            public String ToLowerCase()
            {
                StringBuilder newLine = new StringBuilder(this.str.Length);

                for (int i = 0; i < this.str.Length; i++)
                {
                    newLine.Append(char.ToLower(this.str[i]));
                }

                this.str = newLine;
                return this;
            }

            public String ToUpperCase()
            {
                StringBuilder newLine = new StringBuilder(this.str.Length);

                for (int i = 0; i < this.str.Length; i++)
                {
                    newLine.Append(char.ToUpper(this.str[i]));
                }

                this.str = newLine;
                return this;
            }

            private StringBuilder str;
            private int length;
        }

        static void Main(string[] args)
        {
            String s = new String("НЕ ЗНАЮ... Ну ВОТ что тут писать?? ПРОСТО оставлю это так, как ОНО есть!", 57);
            Console.WriteLine("Строка поменяла регистр: {0}.", s.ToLowerCase());
            Console.WriteLine("Строка поменяла регистр: {0}.", s.ToUpperCase());

            Console.WriteLine("Строка [{0}] длиной {1} символов.", s, s.Length);
            Console.WriteLine("Количество пробелов в строке: {0}.", s.SpacesQuantity());
            s.DeletePoints();
            Console.WriteLine("Строка без пунктуации [{0}] длиной {1} символов.", s, s.Length);
            Console.ReadKey();
        }
    }   
}
