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
            radio1.CheckedChanged += Radio1_CheckedChanged;
            autoFill.CheckedChanged += AutoFill_CheckedChanged;
        }

        private void AutoFill_CheckedChanged(object sender, EventArgs e)
        {
            output.ReadOnly = autoFill.Checked;
            labelM.Visible = inputM.Visible = autoFill.Checked && radio2.Checked;
            labelN.Visible = inputN.Visible = autoFill.Checked;
            output.Clear();
        }

        private void Radio1_CheckedChanged(object sender, EventArgs e)
        {
                 labelM.Visible = radio2.Checked;
                inputM.Visible = radio2.Checked;
                 output.Clear();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (radio1.Checked)
            {
                string[] arr = Input1();
                if (autoFill.Checked)
                {
                    output.Text = "";
                    for (int i = 0; i < arr.Length; i++)
                    {
                        output.Text += arr[i] + " ";
                    }
                }
                output.Text += "\n" + "Сумма элементов интервала: " + Sum1(arr, (int)inputA.Value, (int)inputB.Value) ;
            }
            else
            {
                string[][] arr = Input2();
               if (autoFill.Checked)
                {
                    output.Text = "";
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < arr[i].Length; j++)
                        {
                            output.Text += arr[i][j] + " ";
                        }
                        output.Text += "\n";
                    }
                }
                int Sum2 = 0;
                for (int i =0; i <  inputM.Value ; i++)
                    for (int j = 0; j < inputN.Value ; j++)
                    {
                       int h = Int32.Parse(arr[i][j]);
                        if (h >= inputA.Value && h <= inputB.Value)
                            Sum2 += h;
                    }
                      output.Text += "Сумма элементов интервала: " + Sum2;
              }

        }
        static int Sum1(string[] arr, int a, int b)
        {
            int h, sum = 0;
            foreach (string str in arr)
            {
                h = Int32.Parse(str);
                if (h >= a && h <= b)
                    sum += h;
            }
            return sum;
        }

        string[] Input1()
        {
            string[] arr;
            if (!autoFill.Checked)
            {
                string[] lines;
                try
                {
                    lines = output.Text.Split('\n')[0].Trim().Split(' ');
                }
                catch
                {
                    return new string[0];
                }
                arr = new string[lines.Length];
                Random rand = new Random();
                for (int i = 0; i < lines.Length; i++)
                {
                    try
                    {
                        arr[i] = Convert.ToString(lines[i]);
                    }
                    catch
                    {
                        arr[i] = Convert.ToString(rand.Next() % 10);
                    }
                }
            }
            else
            {
                arr = new string[(int)inputN.Value];
                Random rand = new Random();
                for (int i = 0; i < inputN.Value; i++)
                {
                    arr[i] = Convert.ToString(rand.Next() % 10);
                }
            }
            return arr;
        }
        string[][] Input2()
        {
            string[][] arr;
            if (!autoFill.Checked)
            {
                string[] lines = output.Text.Trim().Split('\n');
                arr = new string[lines.Length][];
                Random rand = new Random();
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] digits = lines[i].Trim().Split(' ');
                    arr[i] = new string[digits.Length];
                    for (int j = 0; j < digits.Length; j++)
                    {
                        try
                        {
                            arr[i][j] = Convert.ToString(digits[j]);
                        }
                        catch
                        {
                            arr[i][j] = Convert.ToString(rand.Next() % 10);
                        }
                    }
                }
            }
            else
            {
                arr = new string[(int)inputN.Value][];
                Random rand = new Random();
                for (int i = 0; i < inputN.Value; i++)
                {
                    arr[i] = new string[(int)inputM.Value];
                    for (int j = 0; j < inputM.Value; j++)
                    {
                        arr[i][j] = Convert.ToString(rand.Next() % 10);
                    }
                }
            }
            return arr;
        }
    }
}
