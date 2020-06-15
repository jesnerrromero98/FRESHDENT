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
    public class accesoDatoCita
    {
        SqlConnection cnx;
        Cita Ci = new Cita();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Cita> listaCita = null;

        public int insertarcita(Cita Cit)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cit", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@FechaCita", Cit.FechaCita);
                cm.Parameters.AddWithValue("@HoraDisponible", Cit.HoraDisponible);
                cm.Parameters.AddWithValue("@Precio", Cit.Precio);
                cm.Parameters.AddWithValue("@Tipo", Cit.Tipo);
                cm.Parameters.AddWithValue("@IdExpediente", Cit.IdExpediente);
                cm.Parameters.AddWithValue(" @IdMedico", Cit.IdMedico);
                
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

        public List<Cita> listarExpediente()
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
                cm.Parameters.AddWithValue("@Tipo","");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue(" @IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCita = new List<Cita>();

                while (dr.Read())
                {
                    Cita Cit = new Cita();
                    Cit.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    Cit.FechaCita= Convert.ToDateTime(dr["FechaCita"].ToString());
                    Cit.HoraDisponible= Convert.ToDateTime(dr["HoraDisponible"].ToString());
                    Cit.Precio = Convert.ToInt32(dr["Precio"].ToString());
                    Cit.Tipo = dr["Tipo"].ToString();
                    Cit.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    Cit.IdCita = Convert.ToInt32(dr["IdCita"].ToString());
                    
                    listaCita.Add(Cit);
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

        public int eliminarcita(int IdCit)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cit", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdCita", IdCit);
                cm.Parameters.AddWithValue("@FechaCita", "");
                cm.Parameters.AddWithValue("@HoraDisponible", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@Tipo", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue(" @IdMedico", "");

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

        public int editarCita(Cita Cit)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cit", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@FechaCita", Cit.FechaCita);
                cm.Parameters.AddWithValue("@HoraDisponible", Cit.HoraDisponible);
                cm.Parameters.AddWithValue("@Precio", Cit.Precio);
                cm.Parameters.AddWithValue("@Tipo", Cit.Tipo);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue(" @IdMedico", "");

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
                cm.Parameters.AddWithValue("@IdCita", dato);
                cm.Parameters.AddWithValue("@FechaCita", dato);
                cm.Parameters.AddWithValue("@HoraDisponible", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@Tipo", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue(" @IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCita = new List<Cita>();

                while (dr.Read())
                {
                    Cita Cit = new Cita();
                    Cit.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    Cit.FechaCita = Convert.ToDateTime(dr["FechaCita"].ToString());
                    Cit.HoraDisponible = Convert.ToDateTime(dr["HoraDisponible"].ToString());
                    Cit.Precio = Convert.ToInt32(dr["Precio"].ToString());
                    Cit.Tipo = dr["Tipo"].ToString();
                    Cit.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    Cit.IdCita = Convert.ToInt32(dr["IdCita"].ToString());
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
