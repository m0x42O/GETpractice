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
            result.Click += result_Click;
        }

        private void result_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(inputX.Value);
            double sum = f(2, x) + f(4, x) + f(6, x);
            output.Text = Convert.ToString(sum);
        }

        static double f(double n, double x)
        {
            return Math.Pow(x, n) / n;
        }
    }
}
