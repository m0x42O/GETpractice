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
            result.Click += Result_Click;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if (S.Value != 0)
            {
                outputLabel.Text = "Ребро куба --> " + Math.Sqrt(Convert.ToDouble(S.Value) / 6);
            }
            else
            {
                outputLabel.Text = "Данные введены некорректно.";
            }
            outputLabel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
