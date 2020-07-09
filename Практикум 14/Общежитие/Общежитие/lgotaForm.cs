using System;
using System.Windows.Forms;

namespace Общежитие
{
    public partial class lgotaForm : Form
    {
        public lgotaForm()
        {
            InitializeComponent();
        }

        private void lgotaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.Lgota". При необходимости она может быть перемещена или удалена.
            this.lgotaTableAdapter.Fill(this.общежитиеDataSet.Lgota);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            lgotaTableAdapter.Update(общежитиеDataSet);
        }
    }
}
