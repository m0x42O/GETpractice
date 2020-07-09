using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            random.CheckedChanged += Random_CheckedChanged;
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int[] arr = Input();
            output.Text += "Массив:";
            for (int i = 0; i < arr.Length; i++)
            {
                output.Text += arr[i] + " ";
            }
            int max = Max(arr);
            int min = Min(arr);
            if (max > min)
                output.Text += "\nМаксимальный элемент встречается позже минимального. Попробуйте снова.";
            else
                Amount(arr, min, max);
                output.Text+="\nСумма элементов: " + Amount(arr, min, max) + "\n";
        }

        int[] Input()
        {
            int[] arr= { 0 };
            try
            {
                if (!random.Checked)
                {
                    string[] lines;
                    try
                    {
                        lines = output.Text.Split('\n')[0].Trim().Split(' ');
                    }
                    catch
                    {
                        return new int[0];
                    }
                    arr = new int[lines.Length];
                    Random rand = new Random();
                    for (int i = 0; i < lines.Length; i++)
                    {
                        try
                        {
                            arr[i] = Convert.ToInt32(lines[i]);
                        }
                        catch
                        {
                            arr[i] = Convert.ToInt32(rand.Next() % 10);
                        }
                    }
                }
                else
                {
                    arr = new int[(int)inputN.Value];
                    Random rand = new Random();
                    for (int i = 0; i < inputN.Value; i++)
                    {
                        arr[i] = Convert.ToInt32(rand.Next() % 10);
                    }
                }
            }
            catch
            {
                output.Text += "Данные введены некорректно. Попробуйте снова.";
            }
            return arr;
        }

        static int Max(int[] arr)
        {
            int index = 0;
            int max = arr[index];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            return index;
        }

        static int Min(int[] arr)
        {
            int index = 0;
            int min = arr[index];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            return index;
        }

        static int Amount(int[] arr, int min, int max)
        {
            int sum = 0;
            for (int i = max + 1; i < min; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        private void Random_CheckedChanged(object sender, EventArgs e)
        {
            output.ReadOnly = random.Checked;
            output.Clear();
        }
    }
}
