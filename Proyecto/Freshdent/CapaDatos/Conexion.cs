using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Librería

namespace CapaDatos
{
    public class Conexion
    {
        public SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection();//Conexión

            //Directorio que conecta la base de datos 
            //cn.ConnectionString = "Data Source=(local);Initial Catalog=FRESHDENT;Integrated Security=True";
            cn.ConnectionString = @"Data Source=(local);Initial Catalog=FRESHDENT;Integrated Security=True"; 
            return cn;
        }
    }
}
