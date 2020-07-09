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
            button.Click += button_Click;
        }

        private void button_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(inputM.Value);
            int k = Convert.ToInt32(inputK.Value);
            int result = Calc(m) + Calc(2 * k);
            output.Text += result + "\n";
        }

        static int Calc(int n, int a = 0)
        {
            if (n-- == 0) return a;
            return Calc(n, 1 + a + n);
        }
    }
}
