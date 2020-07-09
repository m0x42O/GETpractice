using System;
using System.Windows.Forms;

namespace Урок_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            label1.Text = result.ToString();
        }
    }
}
