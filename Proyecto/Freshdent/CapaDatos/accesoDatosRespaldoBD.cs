using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Librería
using System.Data;//Librería

namespace CapaDatos
{
    public class accesoDatosRespaldoBD
    {
        SqlConnection cnx;//Conexión
        Conexion cn = new Conexion();//Conexión
        SqlCommand cm = null;//Comando SQL
        int indicador = 0;//Variable indicador para comprobar CRUD y para cargar datos

        public int respaldarBD()
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión
                cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                cm.ExecuteNonQuery();//Ejecución de consulta
                indicador = 1;//Valor del indicador
            }
            catch (Exception e)
            {
                e.Message.ToString();//Muestra mensaje en caso de ERROR
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();//Cierre de conexión de BD
            }
            return indicador;
        }
    }
}