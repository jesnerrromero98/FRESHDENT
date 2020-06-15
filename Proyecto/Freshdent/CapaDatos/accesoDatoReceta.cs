using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class accesoDatoReceta
    {

        SqlConnection cnx;
        Receta R = new Receta();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Receta> listaReceta = null;

        public int insertarReceta(Receta Re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recet", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@Nombre", Re.Nombre);
                cm.Parameters.AddWithValue("@Presentacion", Re.Presentacion);
                cm.Parameters.AddWithValue("@Cantidad", Re.Cantidad);
                cm.Parameters.AddWithValue("@Descripcion", Re.Descripcion);
               

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public List<Receta> listarReceta()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recet", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Presentacion", "");
                cm.Parameters.AddWithValue("@Cantidad", "");
                cm.Parameters.AddWithValue("@Descripcion", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaReceta = new List<Receta>();

                while (dr.Read())
                {
                   Receta Re = new Receta();
                    Re.IdReceta = Convert.ToInt32(dr["IdExpediente"].ToString());
                    Re.Nombre = dr["Nombres"].ToString();
                    Re.Presentacion = dr["Apellidos"].ToString();
                    Re.Cantidad = Convert.ToInt32(dr["Cantidad"].ToString());
                    Re.Descripcion = dr["Descripcion"].ToString();
                    listaReceta.Add(Re);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaReceta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaReceta;
        }

        public int eliminarReceta(int IdRec)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recet", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdReceta", IdRec);
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Presentacion", "");
                cm.Parameters.AddWithValue("@Cantidad", "");
                cm.Parameters.AddWithValue("@Descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }
      
        //public List<Receta> buscarReceta(string dato)
        //{
        //    try
        //    {
        //        SqlConnection cnx = cn.conectar();

        //        cm = new SqlCommand("Expedient", cnx);
        //        cm.Parameters.AddWithValue("@b", 3);
        //        cm.Parameters.AddWithValue("@IdExpediente", "");
        //        cm.Parameters.AddWithValue("@Cedula", dato);
        //        cm.Parameters.AddWithValue("@Nombres", "");
        //        cm.Parameters.AddWithValue("@Apellidos", "");
        //        cm.Parameters.AddWithValue("@Fecha_Nacimiento", "");
        //        cm.Parameters.AddWithValue("@Telefono_Celular", "");
        //        cm.Parameters.AddWithValue("@Municipio", "");
        //        cm.Parameters.AddWithValue("@Departamento", dato);

        //        cm.CommandType = CommandType.StoredProcedure;
        //        cnx.Open();
        //        dr = cm.ExecuteReader();
        //        listaExpediente = new List<Expediente>();

        //        while (dr.Read())
        //        {
        //            Expediente ex = new Expediente();
        //            ex.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
        //            ex.Cedula = dr["Ceula"].ToString();
        //            ex.Nombres = dr["Nombres"].ToString();
        //            ex.Apellidos = dr["Apellidos"].ToString();
        //            ex.Fecha_Nacimiento = Convert.ToDateTime(dr["Fecha_Nacimiento"].ToString());
        //            ex.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
        //            ex.Municipio = dr["Municipio"].ToString();
        //            ex.Departamento = dr["Departamento"].ToString();
        //            listaExpediente.Add(ex);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        e.Message.ToString();
        //        listaExpediente = null;
        //    }
        //    finally
        //    {
        //        cm.Connection.Close();
        //    }
        //    return listaExpediente;
        //}
    }
}
    
