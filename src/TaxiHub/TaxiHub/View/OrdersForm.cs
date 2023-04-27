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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private string GetSelectedFieldName()
        {
            return driversDataGridView.Columns[driversDataGridView.CurrentCell.ColumnIndex]
                .DataPropertyName;
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiCompanyDataSet);

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.taxiCompanyDataSet.Orders);

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
                ordersBindingSource.Find(GetSelectedFieldName(),
                                          toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }

            if (indexPos > -1)
            {
                ordersBindingSource.Position = indexPos;
            }
            else
            {
                MessageBox.Show("Таких сотрудников нет",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                ordersBindingSource.Position = 0;
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
                        ordersBindingSource.Filter =
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
                ordersBindingSource.Filter = "";
            }

            if (ordersBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                ordersBindingSource.Filter = "";
                FilterCheckBox.Checked = false;
            }
        }
    }
}
