using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GSMS.App_Code
{
    class DBConnection
    {
        SqlConnection connection;
        public DBConnection()
        {
            connection = new SqlConnection(@"Data Source=GOKULSVICTUS\SQLEXPRESS;Initial Catalog=gsms_db;Integrated Security=True");
        }
        public SqlConnection connect()
        {
            connection.Open();
            return connection;
        }
        public void disconnect()
        {
            connection.Close();
        }
    }
}
