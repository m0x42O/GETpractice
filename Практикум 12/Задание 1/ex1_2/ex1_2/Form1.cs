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
            String str1 = new String(new StringBuilder("waaassuuup"));
            String str2 = (String)"waaassuuup";
            outputBox.Text += str1 & str2;
            outputBox.Text += "\n";
            outputBox.Text += str1 & +str2;
            outputBox.Text += "\n";
            outputBox.Text += str2.Line;
            outputBox.Text += "\n";
            outputBox.Text += (-str2).Line;
            outputBox.Text += "\n";
            String str3 = (String)"";
            if (!str3) outputBox.Text += "В str3 пусто.";         
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
            public String(StringBuilder str)
            {
                this.str = str;
                this.length = this.str.Length;
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
                StringBuilder newStr = new StringBuilder(this.str.Length);

                for (int i = 0; i < this.str.Length; i++)
                {
                    newStr.Append(char.ToLower(this.str[i]));
                }

                this.str = newStr;
                return this;
            }

            public String ToUpperCase()
            {
                StringBuilder newStr = new StringBuilder(this.str.Length);

                for (int i = 0; i < this.str.Length; i++)
                {
                    newStr.Append(char.ToUpper(this.str[i]));
                }

                this.str = newStr;
                return this;
            }

            public override string ToString()
            {
                return str.ToString();
            }
            private StringBuilder str;
            private int length;

            public StringBuilder Line
            {
                get { return str; }
                set { str = value; length = value.Length; }
            }

            public char this[int index]
            {
                get { return this.str[index]; }
                set { this.str[index] = value; }
            }
            public static String operator +(String str1)
            {
                return str1.ToUpperCase();
            }

            public static String operator -(String str1)
            {
                return str1.ToLowerCase();
            }

            public static implicit operator bool(String str1)
            {
                return str1.Length != 0;
            }

            public static bool operator &(String op1, String op2)
            {
                if (op1.Length != op2.Length) return false;

                for (int i = 0; i < op1.Length; i++)
                {
                    if (char.ToLower(op1[i]) != char.ToLower(op2[i])) return false;
                }

                return true;
            }

            public static explicit operator string(String str1)
            {
                return str1.str.ToString();
            }

            public static explicit operator String(string str1)
            {
                return new String(new StringBuilder(str1));
            }
        }


        
    }
}
