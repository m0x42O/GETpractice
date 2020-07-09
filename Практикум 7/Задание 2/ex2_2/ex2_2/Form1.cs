using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_2
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
            string s = inputS.Text;
            string word = inputWord.Text;
            resultBox.Text += "Слово [" + word + "] встречается " + Quantity(s, word) + " раз(а).";
        }

        static string deletePointing(string str)
        {
            StringBuilder strb = new StringBuilder(str);
            for (int i = 0; i < strb.Length;)
            {
                if (char.IsPunctuation(strb[i])) { strb.Remove(i, 1); }
                else { ++i; }
            }
            return strb.ToString();
        }

        static int Quantity(string str, string word)
        {
            int number = 0;
            str = deletePointing(str);
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (word == words[i]) number++;
            }
            return number;
        }
    }
}
