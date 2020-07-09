using System;
using System.Windows.Forms;
using System.Drawing;

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
            try
            {
                int result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                label1.Text = result.ToString();
            }
            catch(DivideByZeroException ex)
            {
                statusStrip1.Items[0].Text = ex.Message;
            }
            catch
            {
                label1.Text = "Неизвестная ошибка!";
            }
        }

        private void statusStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Сlicked status bar");
        }

        private void statusStrip1_Resize(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Width = statusStrip1.Width - 200;
        }

        private void toolStripStatusLabel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Blue, width: 2), 2, 2, 15, 15);
        }
    }
}
