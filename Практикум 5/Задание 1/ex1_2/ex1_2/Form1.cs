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
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, h = 0;
            try
            {
                a = Convert.ToDouble(inputA.Value);
                b = Convert.ToDouble(inputB.Value);
                h = Convert.ToDouble(inputH.Value);
            }
            catch
            {
                output.Text += ("Данные введены некорректно.");
            }
            if (h > 0)
            {
                for (double i = a; i < b; i += h)
                {
                    try
                    {
                        output.Text += ("f(" + i + ") = " + f(i)) + "\n";
                    }
                    catch (Exception exc)
                    {
                        output.Text += ("f(" + i + ") = " + exc.Message) + "\n";
                    }
                }
            }
            else
            {
                output.Text += ("Параметр h введен некорректно.");
            }
        }

        static double f(double x)
        {
            if (x == -1)
            {
                throw new Exception("Функция не определена.");
            }
            return (3 * x + 4) / (Math.Sqrt(x * x + 2 * x + 1));
        }
    }
}
