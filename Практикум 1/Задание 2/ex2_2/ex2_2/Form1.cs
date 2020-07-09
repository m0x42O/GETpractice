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
            result.Click += Result_Click;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            string strNumeric = numeric.Value.ToString();
            int res = Convert.ToInt32(strNumeric[0].ToString())+ Convert.ToInt32(strNumeric[1].ToString());
            if (res % 2 == 0)
            {
                output.Text = "Сумма четная.";
            }
            else
            {
                output.Text = "Сумма не четная.";
            }
        }
    }
}
