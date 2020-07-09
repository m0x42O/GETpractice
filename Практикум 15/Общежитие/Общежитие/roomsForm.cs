using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Общежитие
{
    public partial class roomsForm : Form
    {
        public roomsForm()
        {
            InitializeComponent();
        }

        private void roomsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.общежитиеDataSet.Rooms);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            roomsTableAdapter.Update(общежитиеDataSet);
        }
    }
}
