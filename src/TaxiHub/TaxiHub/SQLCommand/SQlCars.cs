using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiHub.SQLCommand
{
    public class SQlCars : SQlBase
    {
        public string SQLCommand { get; } = "SELECT * FROM Cars";
    }
}
