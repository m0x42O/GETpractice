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
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(inputA.Value);
            int b = Convert.ToInt32(inputB.Value);
            if (a < b)
            {
                while (a <= b)
                {
                    Recursion(a);
                    outputBox.Text += "\n";
                    a++;
                }
            }
            else
            {
                outputBox.Text += "B должно быть БОЛЬШЕ A.";
            }
        }

        private void Recursion(int n)
        {
            if (n != 0)
            {
                Recursion(n / 10);
                outputBox.Text += (n % 10) + " ";
            }
        }
    }
}
