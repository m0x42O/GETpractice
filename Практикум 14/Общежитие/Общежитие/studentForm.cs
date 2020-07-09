using System;
using System.Windows.Forms;

namespace Общежитие
{
    public partial class studentForm : Form
    {
        public studentForm()
        {
            InitializeComponent();
        }

        private void studentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.общежитиеDataSet.Students);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            studentsTableAdapter.Update(общежитиеDataSet);
        }
    }
}
