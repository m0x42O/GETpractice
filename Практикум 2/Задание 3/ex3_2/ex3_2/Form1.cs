using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3_2
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
            int A, B;
            A = Convert.ToInt32(inputA.Value);
            B = Convert.ToInt32(inputB.Value);
            if (A <= B)
            {
                for (int i = B; i >= A; i--)
                {
                    outputBox.Text+= (i * i * i + " ");
                }

            }
            else
            {
                outputBox.Text = ("Не соблюдается условие A <= B. Попробуйте снова.");
            }
        }
    }
}
