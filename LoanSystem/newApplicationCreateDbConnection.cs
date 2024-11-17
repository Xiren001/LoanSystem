using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem
{
    internal class newApplicationCreateDbConnection
    {

        public string dbconnect()
        {
            string conn = "server=localhost;user=root;password=;database=LoanWise";
            return conn;
        }

    }
}
