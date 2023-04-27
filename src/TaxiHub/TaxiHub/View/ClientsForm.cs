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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private string GetSelectedFieldName()
        {
            return clientsDataGridView.Columns[clientsDataGridView.CurrentCell.ColumnIndex]
                .DataPropertyName;
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiCompanyDataSet);

        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.Clients".
            // При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.taxiCompanyDataSet.Clients);
            clientsDataGridView
                .Columns["dataGridViewTextBoxColumnBalance"]
                .DefaultCellStyle.Format = "c";
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
                clientsBindingSource.Find(GetSelectedFieldName(),
                                          toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }

            if (indexPos > -1)
            {
                clientsBindingSource.Position = indexPos;
            }
            else
            {
                MessageBox.Show("Таких сотрудников нет",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                clientsBindingSource.Position = 0;
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
                        clientsBindingSource.Filter =
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
                clientsBindingSource.Filter = "";
            }

            if (clientsBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                clientsBindingSource.Filter = "";
                FilterCheckBox.Checked = false;
            }
        }
    }
}
