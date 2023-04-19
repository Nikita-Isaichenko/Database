using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiHub.View
{
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();
        }

        private void driversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiCompanyDataSet);

        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.Drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.taxiCompanyDataSet.Drivers);

        }

        private void driversDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((driversDataGridView.Rows[e.RowIndex]
                .Cells["dataGridViewTextBoxColumnSex"]
                .Value == null))
            {
                e.CellStyle.BackColor = Color.LightGreen;
            }
            else
            {
                if (driversDataGridView.Rows[e.RowIndex]
                .Cells["dataGridViewTextBoxColumnSex"]
                .Value.ToString() == "Мужской")
                {
                    e.CellStyle.BackColor = Color.SkyBlue;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Pink;
                }
            }
            
        }            
    }
}
