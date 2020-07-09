using System;
using System.Windows.Forms;

namespace Урок_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is ButtonBase)
                {
                    ((ButtonBase)c).FlatStyle = FlatStyle.System;
                }
            }
        }
    }
}
