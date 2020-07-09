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
            result.Click += result_Click;
        }

        private void result_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(inputA.Value), b = Convert.ToDouble(inputB.Value), h = Convert.ToDouble(inputH.Value);
            if (h > 0)
            {
                for (double i = a; i <= b; i += h)
                {
                    output.Text += "f(" + i + ") = " + f(i) + "\n";
                }
            }
            else output.Text += "Параметр h введен некорректно.";
        }

        static double f(double x)
        {
            double y;
            if (Math.Abs(x) <= 1)
            {
                y = Math.Pow(x, 2) - 1;
            }
            else if (Math.Abs(x) > 2)
            {
                y = Math.Pow(x, 5) - 1;
            }
            else y = 2 * x - 1;
            return y;
        }
    }
}
