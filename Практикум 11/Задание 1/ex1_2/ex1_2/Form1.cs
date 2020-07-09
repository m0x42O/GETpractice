using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ex1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String s = new String("НЕ ЗНАЮ... Ну ВОТ что тут писать?? ПРОСТО оставлю это так, как ОНО есть!", 57);
            outputBox.Text += "Строка поменяла регистр: " + s.ToLowerCase() + ".";
            outputBox.Text += "Строка поменяла регистр: " + s.ToUpperCase() + ".";
            outputBox.Text += "Строка [" + s + "] длиной " + s.Length + " символов.";
            outputBox.Text += "\n\nКоличество пробелов в строке: " + s.SpacesQuantity() + ".";
            s.DeletePoints();
            outputBox.Text += "\n\nСтрока без пунктуации [" + s + "] длиной " + s.Length + " символа.";
        }

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
            public override string ToString()
            {
                return str.ToString();
            }
            private StringBuilder str;
            private int length;
        }
    }
}
