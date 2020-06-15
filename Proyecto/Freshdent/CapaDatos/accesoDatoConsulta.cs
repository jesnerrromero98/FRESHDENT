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
    public class accesoDatoConsulta
    {
        SqlConnection cnx;
        Consulta Con = new Consulta();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Consulta> listaConsulta = null;

        public int insertarconsulta(Consulta Cons)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Consul", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", Con.Fecha);
                cm.Parameters.AddWithValue("@Hora", Con.Hora);
                cm.Parameters.AddWithValue("@Sintoma", Con.Sintoma);
                cm.Parameters.AddWithValue("@Diagnostico", Con.Diagnostico);
                cm.Parameters.AddWithValue("@IdExpediente", Con.IdExpediente);
                cm.Parameters.AddWithValue(" @IdMedico", Con.IdMedico);

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

        public List<Consulta> listarCita()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Consult", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Sintoma", "");
                cm.Parameters.AddWithValue("@Diagnostico", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue(" @IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaConsulta = new List<Consulta>();

                while (dr.Read())
                {
                    Consulta Con = new Consulta();
                    Con.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    Con.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                    Con.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                    Con.Hora = Convert.ToDateTime(dr["Hora"].ToString());
                    Con.Diagnostico =dr["Diagnostico"].ToString();
                    Con.Sintoma = dr["Sintoma"].ToString();
                    Con.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                  
                    listaConsulta.Add(Con);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaConsulta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaConsulta;
        }

        public int eliminarConsulta(int IdCon)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Consult", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdConsulta", IdCon);
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Sintoma", "");
                cm.Parameters.AddWithValue("@Diagnostico", "");
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

        //public int editarCita(Cita Cit)
        //{
        //    try
        //    {
        //        SqlConnection cnx = cn.conectar();

        //        cm = new SqlCommand("Cit", cnx);
        //        cm.Parameters.AddWithValue("@b", 4);
        //        cm.Parameters.AddWithValue("@IdCita", "");
        //        cm.Parameters.AddWithValue("@FechaCita", Cit.FechaCita);
        //        cm.Parameters.AddWithValue("@HoraDisponible", Cit.HoraDisponible);
        //        cm.Parameters.AddWithValue("@Precio", Cit.Precio);
        //        cm.Parameters.AddWithValue("@Tipo", Cit.Tipo);
        //        cm.Parameters.AddWithValue("@IdExpediente", "");
        //        cm.Parameters.AddWithValue(" @IdMedico", "");

        //        cm.CommandType = CommandType.StoredProcedure;
        //        cnx.Open();
        //        cm.ExecuteNonQuery();
        //        indicador = 1;
        //    }
        //    catch (Exception e)
        //    {
        //        e.Message.ToString();
        //        indicador = 0;
        //    }
        //    finally
        //    {
        //        cm.Connection.Close();
        //    }
        //    return indicador;
        //}

        //public List<Cita> buscarCita(string dato)
        //{
        //    try
        //    {
        //        SqlConnection cnx = cn.conectar();

        //        cm = new SqlCommand("Cit", cnx);
        //        cm.Parameters.AddWithValue("@b", 5);
        //        cm.Parameters.AddWithValue("@IdCita", dato);
        //        cm.Parameters.AddWithValue("@FechaCita", dato);
        //        cm.Parameters.AddWithValue("@HoraDisponible", "");
        //        cm.Parameters.AddWithValue("@Precio", "");
        //        cm.Parameters.AddWithValue("@Tipo", "");
        //        cm.Parameters.AddWithValue("@IdExpediente", "");
        //        cm.Parameters.AddWithValue(" @IdMedico", "");

        //        cm.CommandType = CommandType.StoredProcedure;
        //        cnx.Open();
        //        dr = cm.ExecuteReader();
        //        listaCita = new List<Cita>();

        //        while (dr.Read())
        //        {
        //            Cita Cit = new Cita();
        //            Cit.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
        //            Cit.FechaCita = Convert.ToDateTime(dr["FechaCita"].ToString());
        //            Cit.HoraDisponible = Convert.ToDateTime(dr["HoraDisponible"].ToString());
        //            Cit.Precio = Convert.ToInt32(dr["Precio"].ToString());
        //            Cit.Tipo = dr["Tipo"].ToString();
        //            Cit.IdMedico = Convert.ToInt32(dr["Telefono_Celular"].ToString());
        //            Cit.IdCita = Convert.ToInt32(dr["Municipio"].ToString());
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        e.Message.ToString();
        //        listaCita = null;
        //    }
        //    finally
        //    {
        //        cm.Connection.Close();
        //    }
        //    return listaCita;
        //}
    }
}
