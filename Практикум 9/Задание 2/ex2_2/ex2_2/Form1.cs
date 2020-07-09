using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_2
{
    public partial class Form1 : Form
    {
        const string filename = "chars.txt";
        string[] lines = File.ReadAllLines(filename);

        public Form1()
        {
            InitializeComponent();
            textBox.Text = String.Join("\n", lines);
            inputK1.ValueChanged += inputK1_ValueChanged;
            inputK2.ValueChanged += inputK2_ValueChanged;
        }

        static string stringModify(string s, int k1, int k2)
        {
            if (s.Length < k1) return "";
            if (s.Length < k2) return s.Substring(k1);
            return s.Substring(k1, k2 - k1 + 1);
        }

        static string[] linesModify(string[] lines, int k1, int k2)
        {
            return lines
                    .Select(str => stringModify(str, k1, k2))
                    .ToArray();
        }

        private void HandleData()
        {
            outputBox.Clear();
            string[] lines = File.ReadAllLines(filename);
            int k1 = Convert.ToInt32(inputK1.Value);
            int k2 = Convert.ToInt32(inputK2.Value);
            lines = linesModify(lines, k1, k2);
            outputBox.Text += String.Join("\n", lines);
        }

        private void inputK1_ValueChanged(object sender, EventArgs e)
        {
            inputK2.Minimum = inputK1.Value;
            HandleData();
        }

        private void inputK2_ValueChanged(object sender, EventArgs e)
        {
            HandleData();
        }

    }
}
