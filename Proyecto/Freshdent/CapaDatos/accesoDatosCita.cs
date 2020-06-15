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
    public class accesoDatosCita
    {
        SqlConnection cnx;
        Cita ct = new Cita();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Cita> listaCita = null;

        public int insertarCita(Cita ct)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cit", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@FechaCita", ct.FechaCita);
                cm.Parameters.AddWithValue("@HoraDisponible", ct.HoraDisponible);
                cm.Parameters.AddWithValue("@Precio", ct.Precio);
                cm.Parameters.AddWithValue("@Tipo", ct.Tipo);
                cm.Parameters.AddWithValue("@IdExpediente", ct.IdExpediente);
                cm.Parameters.AddWithValue("@IdMedico", ct.IdMedico);

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

        public List<Cita> listarCita()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cit", cnx);
                cm.Parameters.AddWithValue("@b", 3);

                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@FechaCita", "");
                cm.Parameters.AddWithValue("@HoraDisponible", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@Tipo", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCita = new List<Cita>();

                while (dr.Read())
                {
                    Cita ct = new Cita();
                    ct.IdCita = Convert.ToInt32(dr["IdCita"].ToString());
                    ct.FechaCita = Convert.ToDateTime(dr["FechaCita"].ToString());
                    ct.HoraDisponible = Convert.ToDateTime(dr["HoraDisponible"].ToString());
                    ct.Precio = Convert.ToInt32(dr["Precio"].ToString());
                    ct.Tipo = dr["Tipo"].ToString();
                    ct.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    ct.Nombres = dr["Nombres"].ToString();
                    ct.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    ct.NombreMedico = dr["NombreMedico"].ToString();
                    //resultado de una consulta de dos tablas
                    //agregamos todos los campos que deseamos filtrar

                    listaCita.Add(ct);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCita = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCita;
        }

        public int eliminarCita(int IdC)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cit", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdCita", IdC);
                cm.Parameters.AddWithValue("@FechaCita", "");
                cm.Parameters.AddWithValue("@HoraDisponible", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@Tipo", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

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
        public int editarCita(Cita ct)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cit", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdCita", ct.IdCita);
                cm.Parameters.AddWithValue("@FechaCita", ct.FechaCita);
                cm.Parameters.AddWithValue("@HoraDisponible",ct.HoraDisponible);
                cm.Parameters.AddWithValue("@Precio", ct.Precio);
                cm.Parameters.AddWithValue("@Tipo", ct.Tipo);
                cm.Parameters.AddWithValue("@IdExpediente", ct.IdExpediente);
                cm.Parameters.AddWithValue("@IdMedico", ct.IdMedico);

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

        public List<Cita> buscarCita(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cit", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@FechaCita", "");
                cm.Parameters.AddWithValue("@HoraDisponible", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@Tipo", dato);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCita = new List<Cita>();

                while (dr.Read())
                {
                    Cita ct = new Cita();
                    ct.IdCita = Convert.ToInt32(dr["IdCita"].ToString());
                    ct.FechaCita = Convert.ToDateTime(dr["FechaCita"].ToString());
                    ct.HoraDisponible = Convert.ToDateTime(dr["HoraDisponible"].ToString());
                    ct.Precio = Convert.ToInt32(dr["Precio"].ToString());
                    ct.Tipo = dr["Tipo"].ToString();
                    ct.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    ct.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    listaCita.Add(ct);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCita = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCita;
        }
    }
}
