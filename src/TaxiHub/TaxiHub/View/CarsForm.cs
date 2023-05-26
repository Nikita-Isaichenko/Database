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
    public partial class CarsForm : Form
    {
        private string _currentCarNumber;

        public CarsForm()
        {
            InitializeComponent();     
        }

        public void SetDefault()
        {
            toolStripButtonSelected.Visible = false;
            carsBindingSource.Position = 0;
        }
        
        public string ShowSelectForm(string carNumber)
        {
            toolStripButtonSelected.Visible = true;
            _currentCarNumber = carNumber;

            if (ShowDialog() == DialogResult.OK)
            {
                return
                ((DataRowView)carsBindingSource.Current)["CarNumber"].ToString();
            }                
            else
            {
                return "";
            }
        }

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiCompanyDataSet);

        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.Drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.taxiCompanyDataSet.Drivers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.taxiCompanyDataSet.Cars);

            foreach (var item in taxiCompanyDataSet.Cars.Columns)
            {
                PropertyCarsBindingSourceToolStripComboBox
                    .Items.Add(item.ToString());
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

            var selectedItem = PropertyCarsBindingSourceToolStripComboBox.SelectedItem;

            if (selectedItem is null)
            {
                MessageBox.Show("Вы не задали свойство, по которому проводить поиск",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            int indexPos;

            try
            {
                indexPos =
                carsBindingSource.Find(selectedItem.ToString(), toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }

            if (indexPos > -1)
            {
                carsBindingSource.Position = indexPos;
            }
            else
            {
                MessageBox.Show("Таких сотрудников нет",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                carsBindingSource.Position = 0;
            }
        }

        private void FilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var selectedItem = PropertyCarsBindingSourceToolStripComboBox.SelectedItem;

            if (FilterCheckBox.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали",
                                    "Внимание",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else if (selectedItem is null)
                {
                        MessageBox.Show("Вы не задали свойство, по которому проводить поиск",
                                        "Внимание",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);                        
                }
                else
                {
                    try
                    {
                        carsBindingSource.Filter =
                         selectedItem.ToString() + "='" + toolStripTextBoxFind.Text + "'";
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
                carsBindingSource.Filter = "";
            }

            if (carsBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                carsBindingSource.Filter = "";
                FilterCheckBox.Checked = false;
            }
        }

        private void toolStripButtonSelected_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CarsForm_Shown(object sender, EventArgs e)
        {
            carsBindingSource.Position = 
                carsBindingSource.Find("CarNumber", _currentCarNumber);
        }
    }
}
