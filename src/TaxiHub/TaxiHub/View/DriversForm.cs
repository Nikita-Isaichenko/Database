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

        private string GetSelectedFieldName()
        {
            return driversDataGridView.Columns[driversDataGridView.CurrentCell.ColumnIndex]
                .DataPropertyName;
        }

        private void driversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            driversBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(taxiCompanyDataSet);
        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу
            // "taxiCompanyDataSet.Drivers". При необходимости она может быть перемещена или удалена.
            driversTableAdapter.Fill(taxiCompanyDataSet.Drivers);

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

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            int indexPos;

            try
            {
                indexPos =
                driversBindingSource.Find(GetSelectedFieldName(),
                                          toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }

            if (indexPos > -1)
            {
                driversBindingSource.Position = indexPos;
            }                
            else
            {
                MessageBox.Show("Таких сотрудников нет",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                driversBindingSource.Position = 0;
            }
        }

        private void FilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FilterCheckBox.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали",
                                    "Внимание",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                       driversBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
                }                    
            }
            else
            {
                driversBindingSource.Filter = "";
            }
                
            if (driversBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                driversBindingSource.Filter = "";
                FilterCheckBox.Checked = false;
            }
        }
    }
}
