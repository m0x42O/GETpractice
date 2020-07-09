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

namespace Урок_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string s in drives)
            {
                TreeNode tn = treeView1.Nodes.Add(s);
                tn.Nodes.Add("");
                tn.Tag = "";
            }

        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            NodeExpand(e.Node);
        }
    }
}
