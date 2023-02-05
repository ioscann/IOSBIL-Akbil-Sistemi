using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Akbil_projesi
{
    class sqlConnection
    {
        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = IOSCAN\SQLEXPRESS; Initial Catalog = dbIOSBIL; Integrated Security = True");
            connection.Open();
            return connection;
        }
    }
}
