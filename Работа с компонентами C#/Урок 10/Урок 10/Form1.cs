using System;
using System.Drawing;
using System.Windows.Forms;

namespace Урок_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Size sz = SystemInformation.PrimaryMonitorSize;
            String cn = SystemInformation.ComputerName;
            int k = SystemInformation.MouseButtons;
            Font f = SystemInformation.MenuFont;
            String fn = f.Name;
            bool b = SystemInformation.Network;
            String un = SystemInformation.UserName;
            int w = SystemInformation.VerticalScrollBarWidth;
            richTextBox1.Text = "Размер экрана: " + sz.ToString() + "\nИмя компьютера: " + cn + "\nКнопки мыши: " + k + "\nШрифт: " + fn + "\nПрисутствие сети: " + b + "\nИмя пользователя: " + un + "\nШирина вертикальной полосы прокрутки: " + w + "\n";
        }
    }
}
