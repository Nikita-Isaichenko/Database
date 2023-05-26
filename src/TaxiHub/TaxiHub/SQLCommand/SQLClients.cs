using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiHub.SQLCommand
{
    public  class SQLClients : SQlBase
    {
        public string SQlCommand { get; }
            = "Select " +
              "PhoneNumber, FirstName+' '+SecondName+' '+MiddleName as FullName " +
              "From Clients";

        public string SelectAll { get; } = "select * from Clients";
    }
}
