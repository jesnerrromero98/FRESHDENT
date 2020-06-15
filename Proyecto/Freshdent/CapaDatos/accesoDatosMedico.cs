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
    public class accesoDatosMedico
    {
        SqlConnection cnx;//Conexión
        Medico md = new Medico();//Se define la clase tomada de la Capa Entidades
        Conexion cn = new Conexion();//Conexión
        SqlCommand cm = null;//Comando SQL
        int indicador = 0;//Variable indicador para comprobar CRUD y para cargar datos
        SqlDataReader dr = null;
        List<Medico> listaMedico = null;

        public int insertarMedico(Medico md)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Medic", cnx);//Nombre del procedimiento
                cm.Parameters.AddWithValue("@b", 1);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreMedico", md.NombreMedico);
                cm.Parameters.AddWithValue("@Telefono_Celular", md.Telefono_Celular);
                cm.Parameters.AddWithValue("@IdEspecialidad", md.IdEspecialidad);

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

        public List<Medico> listarMedico()
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Medic", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 3);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreMedico", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                dr = cm.ExecuteReader();
                listaMedico = new List<Medico>();//Lista de Médico

                while (dr.Read())//Recorre cada registro
                {
                    Medico md = new Medico();
                    md.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    md.NombreMedico = dr["NombreMedico"].ToString();
                    md.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
                    md.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    md.NombreEspecialidad = dr["NombreEspecialidad"].ToString();//Agregamos este campo lo cual trae el nombre de la especialidad como 
                    //resultado de una consulta de dos tablas
                    //agregamos todos los campos que deseamos filtrar
                    listaMedico.Add(md);//Agrega registro encontrado a lista
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();//Muestra mensaje en caso de ERROR
                listaMedico = null;
            }
            finally
            {
                cm.Connection.Close();//Cierre de conexión de BD
            }
            return listaMedico;//Regresa lista
        }

        public int eliminarMedico(int IdMedic)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Medic", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 2);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdMedico", IdMedic);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@NombreMedico", IdMedic);
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");

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
  
        public int editarMedico(Medico md)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Medic", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 4);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdMedico", md.IdMedico);
                cm.Parameters.AddWithValue("@NombreMedico", md.NombreMedico);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@Telefono_Celular", md.Telefono_Celular);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@IdEspecialidad", md.IdEspecialidad);
                //cm.Parameters.AddWithValue("@NombreEspecialidad", md.NombreEspecialidad);
                //Atributo seleccionado para una determinada función

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

        public List<Medico> buscarMedico(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Medic", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 5);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreMedico", dato);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                dr = cm.ExecuteReader();
                listaMedico = new List<Medico>();//Lista de Médico

                while (dr.Read())//Recorre cada registro
                {
                    Medico md = new Medico();
                    md.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    md.NombreMedico = dr["NombreMedico"].ToString();
                    md.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
                    md.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    //md.NombreEspecialidad = dr["NombreEspecialidad"].ToString();
                    listaMedico.Add(md);//Agrega registro encontrado a lista
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();//Muestra mensaje en caso de ERROR
                listaMedico = null;
            }
            finally
            {
                cm.Connection.Close();//Cierre de conexión de BD
            }
            return listaMedico;//Regresa lista
        }
    }
}