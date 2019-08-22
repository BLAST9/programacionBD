using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace capaDatos
{
    class conexion
    {
        public SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-6H3M9U9\BLAST;Initial Catalog=BD_ger;Integrated Security=True";
            return cn;
        }

    }
}
