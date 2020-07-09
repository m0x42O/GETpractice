using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3_2
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
            int n = Convert.ToInt32(inputN.Value);
            int[,] arr = randomArr(n, n);
            outputBox.Text += "Исходный массив: \n";
            outputBox.Text += Output(arr) +"\n";
            Modify(arr);
            outputBox.Text += "Измененный массив: \n";
            outputBox.Text += Output(arr) + "\n";
        }

        static int[,] randomArr(int n, int m)
        {
            int[,] array = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 9);
                }
            }
            return array;
        }

        static int[,] Modify(int[,] array)
        {
            if (array.GetLength(0) % 2 == 0)
            {
                for (int i = 0; i < array.GetLength(0); i += 2)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        int buffer = array[i, j];
                        array[i, j] = array[i + 1, j];
                        array[i + 1, j] = buffer;
                    }
                }
            }

            return array;
        }

        static string Output(int[,] array)
        {
            string outputArr = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    outputArr += array[i, j];
                }
                outputArr += "\n";
            }
            return outputArr;
        }
    }
}
