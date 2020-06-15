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
    public class accesoDatoMedico1
    {
        SqlConnection cnx;
        Medico Me = new Medico();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Medico> listaMedico = null;

        public int insertarEspecialidad(Medico Med)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Medic", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreMedico", Med.NombreMedico);
                cm.Parameters.AddWithValue("@Telefono_Celular", Med.Telefono_Celular);
                cm.Parameters.AddWithValue("@IdEspecialidad", Med.IdEspecialidad);



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

        public List<Medico> listarMedico()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Medic", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreMedico", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaMedico = new List<Medico>();

                while (dr.Read())
                {
                    Medico Med = new Medico();
                    Med.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    Med.NombreMedico = dr["NombreMedico"].ToString();
                    Med.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
                    Med.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    listaMedico.Add(Med);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaMedico = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaMedico;
        }

        public int eliminarMedico(int IdMed)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Medic", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdMedico", IdMed);
                cm.Parameters.AddWithValue("@NombreMedico", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");

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

        public int editarMedico(Medico Med)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Medic", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreMedico", Med.NombreMedico);
                cm.Parameters.AddWithValue("@Telefono_Celular", Med.Telefono_Celular);
                cm.Parameters.AddWithValue("@IdEspecialidad", Med.IdEspecialidad);
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

        public List<Medico> buscarMedico(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Medic", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreMedico", dato);
                cm.Parameters.AddWithValue("@Telefono_Celular",dato);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaMedico = new List<Medico>();

                while (dr.Read())
                {
                    Medico Med = new Medico();
                    Med.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    Med.NombreMedico = dr["NombreMedico"].ToString();
                    Med.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
                    Med.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    listaMedico.Add(Med);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaMedico = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaMedico;
        }
    }
}