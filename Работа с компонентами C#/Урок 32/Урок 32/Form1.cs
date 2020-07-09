using System;
using System.Windows.Forms;

namespace Урок_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button pressed!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
