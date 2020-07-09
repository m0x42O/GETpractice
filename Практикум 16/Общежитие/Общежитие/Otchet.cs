using System;
using System.Windows.Forms;

namespace Общежитие
{
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private void Otchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ОбщежитиеDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.StudentsTableAdapter.Fill(this.ОбщежитиеDataSet.Students);

            this.reportViewer1.RefreshReport();
        }
    }
}
