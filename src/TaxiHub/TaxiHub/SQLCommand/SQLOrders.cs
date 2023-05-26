using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiHub.SQLCommand
{
    public class SQLOrders : SQlBase
    {
        public string SQLCommand { get; }
            = "SELECT Id, Date, Cost, Orders.CarNumber, Color, CarBrand " +
              "From Orders INNER JOIN Cars ON Orders.CarNumber = Cars.CarNumber";
    }

}
