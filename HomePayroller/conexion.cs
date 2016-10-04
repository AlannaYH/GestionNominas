using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HomePayroller
{
    public class conexion
    {
        public SqlConnection con = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=Payroller;Integrated Security=true");
    }
}
