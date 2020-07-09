using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ex1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\temp"))
            {
                Directory.CreateDirectory("C:\\temp\\К1");
                Directory.CreateDirectory("C:\\temp\\К2");
                File.WriteAllText("C:\\temp\\К1\\t1.txt", "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
                File.WriteAllText("C:\\temp\\К1\\t2.txt", "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                File.Create("C:\\temp\\К2\\t3.txt").Close();
                File.WriteAllText("C:\\temp\\К2\\t3.txt", File.ReadAllText("C:\\temp\\К1\\t1.txt") + "\n" + File.ReadAllText("C:\\temp\\К1\\t2.txt"));
                FileInfo t1 = new FileInfo("C:\\temp\\К1\\t1.txt");
                outputBox.Text += "Информация о созданных файлах: ";
                outputBox.Text += "\nПолный путь файла: "+ t1.FullName + ", Размер: " + t1.Length + " символов, Время записи: " + t1.LastWriteTime;
                FileInfo t2 = new FileInfo("C:\\temp\\К1\\t2.txt");
                outputBox.Text += "\nПолный путь файла: " + t2.FullName + ", Размер: " + t2.Length + " символов, Время записи: " + t2.LastWriteTime;
                FileInfo t3 = new FileInfo("C:\\temp\\К2\\t3.txt");
                outputBox.Text += "\nПолный путь файла: " + t3.FullName + ", Размер: " + t3.Length + " символов, Время записи: " + t3.LastWriteTime;
                t2.MoveTo("C:\\temp\\К2\\t2.txt");
                t1.CopyTo("C:\\temp\\К2\\t1.txt");
                Directory.Move("C:\\temp\\К2", "C:\\temp\\All");
                Directory.Delete("C:\\temp\\К1", true);
                string[] f = Directory.GetFiles("C:\\temp\\All");
                outputBox.Text += "\n\nИнформация о файлах папки All: ";
                foreach (string item in f)
                {
                    FileInfo t = new FileInfo(item);
                    outputBox.Text += "\nПолный путь файла: " + t.FullName + ", Размер: " + t.Length + " символов, Время записи: " + t.LastWriteTime;
                }
            }
            else
            {
                outputBox.Text += "\nСоздайте папку temp по адресу: C:\\temp, и попробуйте снова.";
            }
        }
    }
}
