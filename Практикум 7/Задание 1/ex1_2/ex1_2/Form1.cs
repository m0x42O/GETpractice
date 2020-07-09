using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            StringBuilder s = new StringBuilder(inputS.Text);
            char x = inputX.Text.ToCharArray()[0];
            outputBox.Text += stringEdit(s, x).ToString();
        }

        static StringBuilder stringEdit(StringBuilder s, char x)
        {
            for (int i = 0; i < s.Length;)
            {
                if (s[i] == x) s.Remove(i, 1);
                else i++;
            }
            return s;
        }
    }
}
