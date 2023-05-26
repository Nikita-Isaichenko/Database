using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiHub.SQLCommand
{
    public class SQlBase
    {
       protected SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.TaxiCompanyConnectionString);

        public DataTable FillDataGridView(string sqlSelect)
        {
            SqlCommand command = connection.CreateCommand();

            command.CommandText = sqlSelect;

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable FillDataGridView(SqlCommand command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
