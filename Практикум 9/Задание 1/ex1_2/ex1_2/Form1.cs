using System;
using System.IO;
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
        string file = "arr.txt";
        double[] array;
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            inputN.ValueChanged += InputN_ValueChanged;
        }

        private void InputN_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)inputN.Value;
            this.array = randomArr(n, -100, 100);
            outputBox.Text += "Массив:\n";
            outputBox.Text += ArrayToString(this.array);
            recordFile(this.array, this.file);
            outputBox.Text += "\nМассив записан в файл.";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(inputA.Value);
            double b = Convert.ToDouble(inputB.Value);
            array = readFile(file);
            outputBox.Text += "\nКомпоненты, не попадающие в данный диапазон: ";
            outputBox.Text += "\n" + outputArr(arrayModify(array, a, b));
        }

        static double[] randomArr(int n, double min, double max)
        {
            Random rand = new Random();
            double[] arr = new double[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = min + rand.NextDouble() * (max - min);
            }
            return arr;
        }

        static string outputArr(double[] arr)
        {
            string forOutput = "";
            foreach (double num in arr)
            {
                forOutput += num + "\n ";
            }
            return forOutput;
        }

        static void recordFile(double[] arr, string file)
        {
            FileStream f = new FileStream(file, FileMode.OpenOrCreate);
            BinaryWriter f1 = new BinaryWriter(f);
            foreach (double num in arr)
            {
                f1.Write(num);
            }
            f1.Close();
            f.Close();
        }

        static double[] readFile(string file)
        {
            FileStream f = new FileStream(file, FileMode.Open);
            BinaryReader f1 = new BinaryReader(f);
            double[] array = new double[f.Length / 8];
            for (int i = 0; i < f.Length; i += 8)
            {
                f.Seek(i, SeekOrigin.Begin);
                array[i / 8] = f1.ReadDouble();
            }
            f1.Close();
            f.Close();
            return array;
        }

        private string ArrayToString(double[] array)
        {
            return String.Join("\n", array);
        }


        static double[] arrayModify(double[] arr, double a, double b)
        {
            return arr.Where(n => n < a || n > b).ToArray();
        }
    }
}
