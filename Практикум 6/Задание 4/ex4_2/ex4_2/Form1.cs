using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4_2
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
            int[][] arr = randomArr(n, n);
            outputBox.Text += "Массив: \n";
            outputBox.Text += outputArr2(arr);
            int number = Convert.ToInt32(inputNum.Value);
            int[] result = calcNumbers(arr, number);
            outputBox.Text += "Результат: \n";
            outputBox.Text += outputArr1(result);
        }

        static int[][] randomArr(int n, int m)
        {
            int[][] array = new int[n][];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    array[i][j] = rand.Next(0, 9);
                }
            }
            return array;
        }

        static string outputArr1(int[] array)
        {
            string outputArrS = "";
            foreach (int n in array)
            {
                outputArrS += n + " ";
            }
            return outputArrS;
        }

        static string outputArr2(int[][] array)
        {
            string outputArrS = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                outputArrS += outputArr1(array[i]) + "\n";
            }
            return outputArrS;
        }

        static int[] calcNumbers(int[][] array, int number)
        {
            int[] result = new int[array.GetLength(0)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = findNumbers(array[i], number);
            }
            return result;
        }

        static int findNumbers(int[] array, int number)
        {
            int result = 0;
            foreach (int n in array)
            {
                if (n > number) result++;
            }
            return result;
        }
    }
}
