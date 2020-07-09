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
            try
            {
                int result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                label1.Text = result.ToString();
            }
            catch(DivideByZeroException ex)
            {
                label1.Text = ex.Message;
            }
            catch
            {
                label1.Text = "Неизвестная ошибка!";
            }
        }
    }
}
