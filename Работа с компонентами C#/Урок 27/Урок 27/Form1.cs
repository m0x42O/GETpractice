using System;
using System.Drawing;
using System.Windows.Forms;

namespace Урок_27
{
    public partial class Form1 : Form
    {
        Color color;
        int[] customColors = new int[] { 0xFF0000, 0xFFFF00, 0xFF00FF };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.CustomColors = customColors;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                customColors = colorDialog1.CustomColors;
                color = colorDialog1.Color;
            }
        }
    }
}
