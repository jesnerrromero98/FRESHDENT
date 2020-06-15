using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Librería
using CapaEntidades;//Referencia
using System.Data;//Librería

namespace CapaDatos
{
    public class accesoDatosReceta
    {
        SqlConnection cnx;//Conexión
        Receta rc = new Receta();//Se define la clase tomada de la Capa Entidades
        Conexion cn = new Conexion();//Conexión
        SqlCommand cm = null;//Comando SQL
        int indicador = 0;//Variable indicador para comprobar CRUD y para cargar datos
        SqlDataReader dr = null;
        List<Receta> listaReceta = null;

        public int insertarReceta(Receta rc)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Recet", cnx);//Nombre del procedimiento
                cm.Parameters.AddWithValue("@b", 1);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@Nombre", rc.Nombre);
                cm.Parameters.AddWithValue("@Presentacion", rc.Presentacion);
                cm.Parameters.AddWithValue("@Cantidad", rc.Cantidad);
                cm.Parameters.AddWithValue("@Descripcion", rc.Descripcion);

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

        public List<Receta> listarReceta()
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Recet", cnx);//Nombre del procedimiento
                cm.Parameters.AddWithValue("@b", 3);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Presentacion", "");
                cm.Parameters.AddWithValue("@Cantidad", "");
                cm.Parameters.AddWithValue("@Descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                dr = cm.ExecuteReader();
                listaReceta = new List<Receta>();//Lista de Receta

                while (dr.Read())//Recorre cada registro
                {
                    Receta rc = new Receta();
                    rc.IdReceta = Convert.ToInt32(dr["IdReceta"].ToString());
                    rc.Nombre = dr["Nombre"].ToString();
                    rc.Presentacion = dr["Presentacion"].ToString();
                    rc.Cantidad = Convert.ToInt32(dr["Cantidad"].ToString());
                    rc.Descripcion = dr["Descripcion"].ToString();
                    listaReceta.Add(rc);//Agrega registro encontrado a lista
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();//Muestra mensaje en caso de ERROR
                listaReceta = null;
            }
            finally
            {
                cm.Connection.Close();//Cierre de conexión de BD
            }
            return listaReceta;//Regresa lista
        }

        public int eliminarReceta(int IdRec)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Recet", cnx);//Nombre del procedimiento
                cm.Parameters.AddWithValue("@b", 2);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdReceta", IdRec);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Presentacion", "");
                cm.Parameters.AddWithValue("@Cantidad", "");
                cm.Parameters.AddWithValue("@Descripcion", "");

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