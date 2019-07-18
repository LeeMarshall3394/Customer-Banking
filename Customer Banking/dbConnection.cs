using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Assignment_2
{
    class dbConnection
    {
        public static string dbConnect = @"Provider=Microsoft.ACE.OLEDB.12.0;"
                                    + "data source = "
                                    + Application.StartupPath
                                    + @"\Outlaw_Hess.accdb;";
        public static string custID;
        public static string prodID;
        public static string accID;
    }
}
