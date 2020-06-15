using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class accesoDatoEspecialidad

    {
        SqlConnection cnx;
        Especialidad Es = new Especialidad();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Especialidad> listaEspecialidad = null;

        public int insertarEspecialidad(Especialidad Esp)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Especialid", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", Esp.NombreEspecialidad);
                cm.Parameters.AddWithValue("@DescpEspecialidad", Esp.DescpEspecialidad);
                

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

        public List<Especialidad> listarEspecialidad()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Especialid", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", "");
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();

                while (dr.Read())
                {
                    Especialidad Esp = new Especialidad();
                    Esp.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    Esp.NombreEspecialidad = dr["NombreEspecialidad"].ToString();
                    Esp.DescpEspecialidad = dr["DescpEspecialidad"].ToString();
                    listaEspecialidad.Add(Esp);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaEspecialidad = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaEspecialidad;
        }

        public int eliminarEspecialidad(int IdEspec)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Expedient", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdEspecialidad", IdEspec);
                cm.Parameters.AddWithValue("@NombreEspecialidad", "");
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");


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

        public int editarESpecilidad(Especialidad Esp)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Expedient", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdEspecialidad", Esp.IdEspecialidad);
                cm.Parameters.AddWithValue("@NombreEspecialidad", Esp.NombreEspecialidad);
                cm.Parameters.AddWithValue("@DescpEspecialidad", Esp.DescpEspecialidad);
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

        public List<Especialidad> buscarEspecialidad(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Especialid", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", dato);
                cm.Parameters.AddWithValue("@DescpEspecialidad", dato);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();

                while (dr.Read())
                {
                    Especialidad Esp = new Especialidad();
                    Esp.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    Esp.NombreEspecialidad = dr["NombreEspecialidad"].ToString();
                    Esp.DescpEspecialidad = dr["DescpEspecialidad"].ToString();
                    listaEspecialidad.Add(Esp);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaEspecialidad = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaEspecialidad;
        }
    }
}