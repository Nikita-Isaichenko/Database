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
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void feedBackBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.feedBackBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiCompanyDataSet);

        }

        private void FeedBackForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiCompanyDataSet.FeedBack". При необходимости она может быть перемещена или удалена.
            this.feedBackTableAdapter.Fill(this.taxiCompanyDataSet.FeedBack);

        }
    }
}
