using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Урок_28
{
    public partial class Form1 : Form
    {
        Color color;
        string firstName;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            color = Color.MediumPurple;
            firstName = "Ivan";
            Invalidate();
            Properties.Settings.Default.MyColor = color;
            Properties.Settings.Default.FirstName = firstName;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            color = Color.Firebrick;
            firstName = "Roman";
            Invalidate();
            Properties.Settings.Default.MyColor = Color.Firebrick;
            Properties.Settings.Default.FirstName = firstName;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                color = Properties.Settings.Default.MyColor;
                firstName = Properties.Settings.Default.FirstName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);
            g.DrawString(firstName, font, new SolidBrush(color), 100, 100);
        }
    }
}
