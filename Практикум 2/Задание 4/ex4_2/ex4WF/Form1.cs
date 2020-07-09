using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4WF
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
            int num = 7;
            int d = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    outputBox.Text += num;
                    outputBox.Text += " ";
                }
                d++;
                num--;
                outputBox.Text += "\n";
                
            }
            //string[] trash=outputBox.Text.Split('')
        }
    }
}
