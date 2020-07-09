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
            int relevantMonth = DateTime.Now.Month;
            int m = Convert.ToInt32(input.Value);
            for (int i = m; i >= 0; i--)
            {
                if (relevantMonth.Equals(0))
                    relevantMonth = 12;
                relevantMonth--;
            }
            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            output.Text = months[(relevantMonth)];
        }
    }
}
