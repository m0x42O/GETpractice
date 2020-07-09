using System;
using System.Drawing;
using System.Windows.Forms;

namespace Урок_29
{
    public partial class Form1 : Form
    {
        Font userFont = DefaultFont;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                userFont = fontDialog1.Font;
                Invalidate();
            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Test", userFont, Brushes.Blue, 20, 20);
            base.OnPaint(e);
        }

    }
}
