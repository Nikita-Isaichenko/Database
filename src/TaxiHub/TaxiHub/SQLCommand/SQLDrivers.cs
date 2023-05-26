using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaxiHub.SQLCommand
{
    public class SQLDrivers : SQlBase
    {
        public string SQlCommandProfit { get; set; }
            = $"SELECT [Name], SecondName, MiddleName, Cars.CarNumber, sum(Cost) as Profit, count(Orders.CarNumber) as TripsNumber" +
              " FROM Drivers INNER JOIN Cars ON Drivers.DriversLicenseNumber = Cars.Drivers INNER JOIN Orders ON Orders.CarNumber = Cars.CarNumber" +
              " WHERE SecondName LIKE @SecondName and DATEDIFF(day, Orders.Date, GetDate()) < @Countdays" +
              " GROUP BY [Name], SecondName, MiddleName, Cars.CarNumber";

        public SqlCommand SQlCommandProfitWithParameters(string secondName,
                                                     string countDays,
                                                     bool flag1,
                                                     bool flag2,
                                                     string value)
        {
            if (flag1)
            {
                SQlCommandProfit += " HAVING sum(Cost) > @Amount";
            }

            if (flag2)
            {
                SQlCommandProfit += " ORDER BY sum(cost) DESC";
            }

            SqlCommand command = connection.CreateCommand();

            command.CommandText = SQlCommandProfit;
            command.Parameters.AddWithValue("@SecondName", secondName + '%');
            command.Parameters.AddWithValue("@Countdays", countDays);

            if (flag1)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                    Double.Parse(value);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом",
                    "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);                                
                }

            return command;
        }
    }
}
