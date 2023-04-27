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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.taxiCompanyDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.taxiCompanyDataSet.Clients);
            taxiCompanyDataSet.Orders.Columns["Date"].DefaultValue = DateTime.Now;
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            ordersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(taxiCompanyDataSet);
        }
    }
}
