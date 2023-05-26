using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TaxiHub.SQLCommand;
using System.Data.Common;
using System.Diagnostics;

namespace TaxiHub.View
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        

        private void CarsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var sqlCars = new SQlCars();
            SelectDataGridView.DataSource = sqlCars.FillDataGridView(sqlCars.SQLCommand);
        }

        private void ClientsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var sqlClients = new SQLClients();
            SelectDataGridView.DataSource = sqlClients.FillDataGridView(sqlClients.SQlCommand);
        }

        private void OrdersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var sqlOrders = new SQLOrders();
            SelectDataGridView.DataSource = sqlOrders.FillDataGridView(sqlOrders.SQLCommand);
        }

        private void SelectProfitButton_Click(object sender, EventArgs e)
        {
            var sqlDrivers = new SQLDrivers();

            if (string.IsNullOrEmpty(SecondNameTextBox.Text))
            {
                MessageBox.Show("Необходимо ввести фамилию водителя",
                                "Внимание",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }
            if (SelectMoreCheckBox.Checked && string.IsNullOrEmpty(SelectProfitMoreTextBox.Text))
            {
                MessageBox.Show("Не указана прибыль в условии",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                SelectMoreCheckBox.Checked = false;

                return;
            }

            if (PerMonthRadioButton.Checked)
            {
                dataGridView1.DataSource
                    = sqlDrivers.FillDataGridView(
                        sqlDrivers.SQlCommandProfitWithParameters(SecondNameTextBox.Text,
                            "32",
                            SelectMoreCheckBox.Checked,
                            SortDescCheckBox.Checked,
                            SelectProfitMoreTextBox.Text));
            }
            else if (PerYearRadioButton.Checked)
            {
                dataGridView1.DataSource
                    = sqlDrivers.FillDataGridView(
                        sqlDrivers.SQlCommandProfitWithParameters(SecondNameTextBox.Text,
                            "366",
                            SelectMoreCheckBox.Checked,
                            SortDescCheckBox.Checked,
                            SelectProfitMoreTextBox.Text));
            }
            else
            {
                dataGridView1.DataSource
                    = sqlDrivers.FillDataGridView(
                        sqlDrivers.SQlCommandProfitWithParameters(SecondNameTextBox.Text,
                            "9000",
                            SelectMoreCheckBox.Checked,
                            SortDescCheckBox.Checked,
                            SelectProfitMoreTextBox.Text));
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NumberOrderTextBox.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой продажи",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlSelect = "";

            if (CorrelatedSubqueryRadioButton.Checked)
            {
                sqlSelect = "Select * from Orders where @rating in (select Rating from FeedBack where id = Orders.Id_FeedBack)";
            }
            else if (UncorrelatedSubqueryRadioButton.Checked)
            {
                sqlSelect = "Select * from Orders where Id_FeedBack in (select Id from FeedBack where Rating = @rating)";
            }
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.TaxiCompanyConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;

            try
            {
                command.Parameters.Add("@rating", SqlDbType.Int).Value =
                int.Parse(NumberOrderTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть заданчислом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void InsertClients()
        {
            string sqlInsert = "Insert into Clients (PhoneNumber, FirstName, SecondName, MiddleName, Balance) " +
                               "values (@phone, @name, @secondName, @MiddleName, @Balance)";

            SqlConnection connection = new
                        SqlConnection(Properties.Settings.Default.TaxiCompanyConnectionString);

            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.Add("@phone", SqlDbType.BigInt).Value =
                                        Int64.Parse(PhoneTextBox.Text);
            command.Parameters.AddWithValue("@Name", NameTextBox.Text);
            command.Parameters.AddWithValue("@secondName", SecondTextBox.Text);
            command.Parameters.AddWithValue("@MiddleName", MiddleTextBox.Text);
            command.Parameters.Add("@Balance", SqlDbType.Money).Value =
            decimal.Parse(BalanceTextBox.Text);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Close();
        }

        private void UpdateClients()
        {
            string sqlUpdate = "Update Clients set {0} Where Id = @id";
            SqlConnection connection = new
                        SqlConnection(Properties.Settings.Default.TaxiCompanyConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(NameTextBox.Text))
                sqlValues += "FirstName=@Name,";
            if (!String.IsNullOrEmpty(SecondTextBox.Text))
                sqlValues += "SecondName=@secondName,";
            if (!String.IsNullOrEmpty(MiddleTextBox.Text))
                sqlValues += "MiddleName=@middleName,";
            if (!String.IsNullOrEmpty(PhoneTextBox.Text))
                sqlValues += "PhoneNumber=@phone,";
            if (!String.IsNullOrEmpty(BalanceTextBox.Text))
                sqlValues += "Balance=@balance";

            command.CommandText = String.Format(sqlUpdate, sqlValues);

            if (!String.IsNullOrEmpty(NameTextBox.Text))
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value =
                NameTextBox.Text;
            //или другим способом, если необходимо явное указание типа данных
            if (!String.IsNullOrEmpty(SecondTextBox.Text))
                command.Parameters.Add("@secondName", SqlDbType.NVarChar).Value =
                SecondTextBox.Text;
            if (!String.IsNullOrEmpty(MiddleTextBox.Text))
                command.Parameters.Add("@middleName", SqlDbType.NVarChar).Value =
                MiddleTextBox.Text;
            if (!String.IsNullOrEmpty(PhoneTextBox.Text))
                command.Parameters.Add("@phone", SqlDbType.BigInt).Value =
                Int64.Parse(PhoneTextBox.Text);
            if (!String.IsNullOrEmpty(BalanceTextBox.Text))
                command.Parameters.Add("@balance", SqlDbType.Money).Value =
                decimal.Parse(BalanceTextBox.Text);

            command.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(IdClientsTextBox.Text);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        private void DeleteClients()
        {
            string sqlDelete = "Delete from Clients where Id = @id";

            SqlConnection connection = new
                        SqlConnection(Properties.Settings.Default.TaxiCompanyConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;

            command.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(IdClientsTextBox.Text);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }

            connection.Close();
        }

        private void ExecuteRequestButton_Click(object sender, EventArgs e)
        {
            if (InsertRadioButton.Checked)
            {
                InsertClients();
            }
            else if (UpdateRadioButton.Checked)
            {
                UpdateClients();
            }
            else if (DeleteRadioButton.Checked)
            {
                DeleteClients();
            }
            else
            {
                MessageBox.Show("Вы не выбрали действие", "Внимание",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sqlClients = new SQLClients();
            dataGridView3.DataSource = sqlClients.FillDataGridView(sqlClients.SelectAll);
        }
    }
}
