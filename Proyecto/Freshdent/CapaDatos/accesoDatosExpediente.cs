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
    public class accesoDatosExpediente
    {
        SqlConnection cnx;//Conexión
        Expediente e = new Expediente();//Se define la clase tomada de la Capa Entidades
        Conexion cn = new Conexion();//Conexión
        SqlCommand cm = null;//Comando SQL
        int indicador = 0;//Variable indicador para comprobar CRUD y para cargar datos
        SqlDataReader dr = null;
        List<Expediente> listaExpediente = null;

        public int insertarExpediente (Expediente ex)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Expedient", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@Cedula", ex.Cedula);
                cm.Parameters.AddWithValue("@Nombres", ex.Nombres);
                cm.Parameters.AddWithValue("@Apellidos", ex.Apellidos);
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", ex.Fecha_Nacimiento);
                cm.Parameters.AddWithValue("@Telefono_Celular", ex.Telefono_Celular);
                cm.Parameters.AddWithValue("@Municipio", ex.Municipio);
                cm.Parameters.AddWithValue("@Departamento", ex.Departamento);

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

        public List<Expediente> listarExpediente()
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Expedient", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 3);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@Municipio", "");
                cm.Parameters.AddWithValue("@Departamento", "");

                cm.CommandType = CommandType.StoredProcedure;//Tìpo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                dr = cm.ExecuteReader();
                listaExpediente = new List<Expediente>();//Lista de Expediente

                while (dr.Read())//Recorre cada registro
                {
                    Expediente ex = new Expediente();
                    ex.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    ex.Cedula = dr["Cedula"].ToString();
                    ex.Nombres = dr["Nombres"].ToString();
                    ex.Apellidos = dr["Apellidos"].ToString();
                    ex.Fecha_Nacimiento =dr["Fecha_Nacimiento"].ToString();
                    ex.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
                    ex.Municipio = dr["Municipio"].ToString();
                    ex.Departamento = dr["Departamento"].ToString();
                    listaExpediente.Add(ex);//Agrega registro encontrado a lista
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();//Muestra mensaje en caso de ERROR
                listaExpediente = null;
            }
            finally
            {
                cm.Connection.Close();//Cierre de conexión de BD
            }
            return listaExpediente;//Regresa lista
        }

        public int eliminarExpediente (int IdExped)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//COnexión

                cm = new SqlCommand("Expedient", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 2);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdExpediente",IdExped);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@Municipio", "");
                cm.Parameters.AddWithValue("@Departamento", "");

                cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                cm.ExecuteNonQuery();//Ejecución de consulta
                indicador = 1;//Valor del indicador
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

        public int editarExpediente (Expediente ex)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Expedient", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 4);//Valor de parámetro

                //Atrbuto del procedimiento y todos los atributos seleccionados para una determinada función
                cm.Parameters.AddWithValue("@IdExpediente", ex.IdExpediente);
                cm.Parameters.AddWithValue("@Cedula", ex.Cedula);
                cm.Parameters.AddWithValue("@Nombres", ex.Nombres);
                cm.Parameters.AddWithValue("@Apellidos",ex.Apellidos);
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", ex.Fecha_Nacimiento);
                cm.Parameters.AddWithValue("@Telefono_Celular", ex.Telefono_Celular);
                cm.Parameters.AddWithValue("@Municipio", ex.Municipio);
                cm.Parameters.AddWithValue("@Departamento", ex.Departamento);

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

        public List<Expediente> buscarExpediente(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Expedient", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 5);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@Cedula", dato);
                cm.Parameters.AddWithValue("@Nombres",dato);//Atributo seleccionado para una determinada función
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@Municipio", "");
                cm.Parameters.AddWithValue("@Departamento", "");

                cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                dr = cm.ExecuteReader();
                listaExpediente = new List<Expediente>();//Lista de Expediente

                while (dr.Read())//Recorre cada registro
                {
                    Expediente ex = new Expediente();
                    ex.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    ex.Cedula = dr["Cedula"].ToString();
                    ex.Nombres = dr["Nombres"].ToString();
                    ex.Apellidos = dr["Apellidos"].ToString();
                    ex.Fecha_Nacimiento =dr["Fecha_Nacimiento"].ToString();
                    ex.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
                    ex.Municipio = dr["Municipio"].ToString();
                    ex.Departamento = dr["Departamento"].ToString();
                    listaExpediente.Add(ex);//Agrega registros encontrados a lista
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();//Muestra mensaje en caso de ERROR
                listaExpediente = null;
            }
            finally
            {
                cm.Connection.Close();//Cierre de conexión
            }
            return listaExpediente;//Regresa lista
        }
    }
}