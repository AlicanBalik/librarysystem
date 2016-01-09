using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    class SQLConnection
    {
        public static SqlConnection Connection
        {
            get { return new SqlConnection(@"Data Source = (Localdb)\v11.0; Initial Catalog = Library System; Integrated Security = true;"); }
        }
    }
}
