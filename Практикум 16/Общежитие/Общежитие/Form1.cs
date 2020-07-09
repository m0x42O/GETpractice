using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Общежитие
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomsForm form = new roomsForm();
            form.Text = "Комнаты";
            form.ShowDialog();
        }

        private void льготыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lgotaForm form = new lgotaForm();
            form.Text = "Льготы";
            form.ShowDialog();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentForm form = new studentForm();
            form.Text = "Студенты";
            form.ShowDialog();
        }

        private void расселениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RasselenieForm form = new RasselenieForm();
            form.Text = "Расселение";
            form.ShowDialog();
        }

        private void запросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZaprosForm form = new ZaprosForm();
            form.ShowDialog();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Otchet form = new Otchet();
            form.ShowDialog();
        }
    }
}
