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
    public class accesoDatosConsulta
    {
        SqlConnection cnx;//Conexión
        Consulta cs = new Consulta();//Se define la clase tomada de la Capa Entidades
        Conexion cn = new Conexion();//Conexión
        SqlCommand cm = null;//Comando SQL
        int indicador = 0;//Variable indicador para comprobar CRUD y para cargar datos
        SqlDataReader dr = null;
        List<Consulta> listaConsulta = null;

        public int insertarConsulta(Consulta cs)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Consul", cnx);//Nombre del procedimiento
                cm.Parameters.AddWithValue("@b", 1);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", cs.Fecha);
                cm.Parameters.AddWithValue("@Hora", cs.Hora);
                cm.Parameters.AddWithValue("@Sintoma", cs.Sintoma);
                cm.Parameters.AddWithValue("@Diagnostico", cs.Diagnostico);
                cm.Parameters.AddWithValue("@IdExpediente", cs.IdExpediente);
                cm.Parameters.AddWithValue("@IdMedico", cs.IdMedico);

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

        public List<Consulta> listarConsulta()
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Consul", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 3);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Sintoma", "");
                cm.Parameters.AddWithValue("@Diagnostico", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                dr = cm.ExecuteReader();
                listaConsulta = new List<Consulta>();//Lista de Consulta

                while (dr.Read())//Recorre cada registro
                {
                    Consulta cs = new Consulta();
                    cs.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                    cs.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                    cs.Hora= Convert.ToDateTime(dr["Hora"].ToString());
                    cs.Sintoma = dr["Sintoma"].ToString();
                    cs.Diagnostico = dr["Diagnostico"].ToString();
                    cs.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    cs.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());

                    cs.Nombres = dr["Nombres"].ToString();
                    cs.NombreMedico = dr["NombreMedico"].ToString();

                    listaConsulta.Add(cs);//Agrega registro encontrado a lista
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();//Muestra mensaje en caso de ERROR
                listaConsulta = null;
            }
            finally
            {
                cm.Connection.Close();//Cierre de conexión de BD
            }
            return listaConsulta;//Regresa lista
        }

        public int eliminarConsulta(int IdCons)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Consul", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 2);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdConsulta", IdCons);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Sintoma", "");
                cm.Parameters.AddWithValue("@Diagnostico", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

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