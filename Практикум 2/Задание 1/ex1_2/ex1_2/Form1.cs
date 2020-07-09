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
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            float x, y;
            x = (float)xInput.Value;
            y = (float)yInput.Value;
            float sum = (x * x + y * y)*10;
            float r1 = 90, r2 = 490;
            Bitmap map = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(map);
            g.FillEllipse(Brushes.Silver, pictureBox.Width / 2 - 70, pictureBox.Height / 2 - 70,140,140);
            g.FillEllipse(Brushes.White, pictureBox.Width / 2 - 30, pictureBox.Height / 2 - 30,60,60);
            g.FillEllipse(Brushes.Red, pictureBox.Width / 2 + x*10 - 2, pictureBox.Height / 2 - y*10 - 2, 4, 4);
            pictureBox.Image = map;
            if (sum > r1 && sum < r2)
            {
                output.Text=("Точка лежит внутри заштрихованной области.");
            }
            else if (sum == r1 || sum == r2)
            {
                output.Text = ("Точка лежит на границе заштрихованной области.");
            }
            else
            {
                output.Text = ("Точка лежит вне заштрихованной области.");
            }
        }
    }
}
