using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Общежитие
{
    public partial class ZaprosForm : Form
    {
        public ZaprosForm()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            OleDbConnection sqlconn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\\Общежитие.mdb;");
            sqlconn.Open();
            string s = "";
            if (radioButton1.Checked) { s = "SELECT * FROM Students"; }
            if (radioButton2.Checked) { s = "SELECT SNP, Group, Address FROM Students"; }
            if (radioButton3.Checked) { s = "SELECT DISTINCT Group FROM Students"; }
            if (radioButton4.Checked) { s = "SELECT * FROM rooms where Flour=3"; }
            if (radioButton5.Checked) { s = "SELECT * FROM Students where Students.Group like 'ПО%'"; }
            OleDbDataAdapter oda = new OleDbDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Columns.RemoveAt(0);
            }            
        }
    }
} 
