using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Урок_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                treeView1.Nodes.Add(addNodeTextBox.Text);
            }
            else
            {
                node.Nodes.Add(addNodeTextBox.Text);
            }
            addNodeTextBox.Text = "";
            addNodeTextBox.Focus();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node != null)
            {
                treeView1.Nodes.Remove(node);
            }
            else
            {
                MessageBox.Show("Ничего не выделено");
            }
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;
        }
    }
}
