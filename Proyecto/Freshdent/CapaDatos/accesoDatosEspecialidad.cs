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
    public class accesoDatosEspecialidad
    {
        SqlConnection cnx;//Conexión
        Especialidad es = new Especialidad();//Se define la clase tomada de la Capa Entidades
        Conexion cn = new Conexion();//Conexión
        SqlCommand cm = null;//Comando SQL
        int indicador = 0;//Variable indicador para comprobar CRUD y para cargar datos
        SqlDataReader dr = null;
        List<Especialidad> listaEspecialidad = null;

        public int insertarEspecialidad(Especialidad es)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Especialid", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", es.NombreEspecialidad);
                cm.Parameters.AddWithValue("@DescpEspecialidad", es.DescpEspecialidad);

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
                cm.Connection.Close();//CIerre de conexión de BD
            }
            return indicador;
        }

        public List<Especialidad> listarEspecialidad()
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Especialid", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 3);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", "");
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();//Lista de Especialidad

                while (dr.Read())//Recorre cada registro
                {
                    Especialidad es = new Especialidad();
                    es.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    es.NombreEspecialidad = dr["NombreEspecialidad"].ToString();
                    es.DescpEspecialidad = dr["DescpEspecialidad"].ToString();
                    listaEspecialidad.Add(es);//Agrega registros encontrado a lista
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();//Muestra mensaje en caso de ERROR
                listaEspecialidad = null;
            }
            finally
            {
                cm.Connection.Close();//Cierre de conexión de BD
            }
            return listaEspecialidad;//Regresa lista
        }

        public int eliminarEspecialidad(int IdEspec)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Especialid", cnx);//Nombre del procedimiento
                cm.Parameters.AddWithValue("@b", 2);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdEspecialidad", IdEspec);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@NombreEspecialidad", "");
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");

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

        public int editarEspecialidad(Especialidad es)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Especialid", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 4);//Valor de parámetros

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", es.NombreEspecialidad);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@DescpEspecialidad", es.DescpEspecialidad);//Atributo seleccionado para una determinada función

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

        public List<Especialidad> buscarEspecialidad(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Especialid", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 5);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", dato);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();//Lista de Especialidad

                while (dr.Read())//Recorre cada registro
                {
                    Especialidad es = new Especialidad();
                    es.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    es.NombreEspecialidad = dr["NombreEspecialidad"].ToString();
                    es.DescpEspecialidad = dr["DescpEspecialidad"].ToString();
                    listaEspecialidad.Add(es);//Agrega registro encontrado a lista
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();//Muestra mensaje en caso de ERROR
                listaEspecialidad = null;
            }
            finally
            {
                cm.Connection.Close();//Cierre de conexión de BD
            }
            return listaEspecialidad;//Regresa lista
        }
    }
}