using System;
using System.Windows.Forms;

namespace Урок_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.AddRange(new ToolStripItem[]
            {
                cutToolStripMenuItem,
                copyToolStripMenuItem,
                pasteToolStripMenuItem
            });
            ContextMenuStrip = cms;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cut");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paste");
        }
    }
}
