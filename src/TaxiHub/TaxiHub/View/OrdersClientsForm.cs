using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiHub.Services;

namespace TaxiHub.View
{
    public partial class OrdersClientsForm : Form
    {
        public OrdersClientsForm()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.taxiCompanyDataSet);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrdersClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.FeedBack". При необходимости она может быть перемещена или удалена.
            this.feedBackTableAdapter.Fill(this.taxiCompanyDataSet.FeedBack);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.taxiCompanyDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.taxiCompanyDataSet.Clients);
            taxiCompanyDataSet.Orders.Columns["Date"].DefaultValue = DateTime.Now;
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                ordersBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(taxiCompanyDataSet);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string carNumber = "";

                if (((DataRowView)ordersBindingSource.Current)["CarNumber"].ToString() != "")
                {
                    carNumber = ((DataRowView)ordersBindingSource.Current)["CarNumber"].ToString();
                }

                carNumber = SingletonFactoryForm.CarsForm.ShowSelectForm(carNumber);

                if (carNumber != "")
                {
                    MessageBox.Show(carNumber.ToString());
                    ((DataRowView)ordersBindingSource.Current)["CarNumber"] = carNumber;
                    
                }
            }
        }
    }
}
