using System;
using System.Collections.Generic;
using System.Data;//Librería
using System.Data.SqlClient;//Librería
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;//Referencia

namespace CapaDatos
{
    public class InicioSesion
    {
        SqlConnection cnx;//Conexión
        Inicio cs = new Inicio();//Se define la clase tomada de la Capa Entidades
        Conexion cn = new Conexion();//Conexión
        SqlCommand cm = null;//Comando SQL
        int indicador = 0;//Variable indicador para comprobar CRUD y para cargar datos
        SqlDataReader dr = null;
        List<Inicio> listaInicio = null;

        public int insertarinicio(Inicio In)
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Consul", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1);//Valor de parámetro
                cm.Parameters.AddWithValue("@UserID", "");//Atributos del procedimiento 
                cm.Parameters.AddWithValue("@LoginName", In.LoginName);
                cm.Parameters.AddWithValue("@Password", In.Password);
           
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

        public Inicio iniciarSesion(string usuario, string contaseña)
        {
            cnx = cn.conectar();//Conexión
            cm = new SqlCommand("Us", cnx);//Nombre del procedimiento SQL
            cm.Parameters.AddWithValue("@b", 4);//Valor de parámetros
            cm.Parameters.AddWithValue("@LoginName", $"{usuario}");//Atributos del procedimiento
            cm.Parameters.AddWithValue("@Password", $"{contaseña}");
            cm.Parameters.AddWithValue("@UserID", "");

            cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
            cnx.Open();//Abrir conexión de BD
            dr = cm.ExecuteReader();
            if (dr.Read() && dr.HasRows)//Recorre cada registro
            {
                return new Inicio()
                {
                    LoginName = dr["LoginName"].ToString(),
                    Password = dr["Password"].ToString(),
                    UserID = Convert.ToInt32(dr["UserID"].ToString())
                };
            }
            else
            {
                throw new Exception("Usuario no encontrado.");
            }
            
        }

        public List<Inicio> listarInicio()
        {
            try
            {
                SqlConnection cnx = cn.conectar();//Conexión

                cm = new SqlCommand("Us", cnx);//Nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 2);//Valor de parámetro

                //Atributos del procedimiento
                cm.Parameters.AddWithValue("@LoginName", "");
                cm.Parameters.AddWithValue("@Password", "");
                cm.Parameters.AddWithValue("@UserID", "");
            

                cm.CommandType = CommandType.StoredProcedure;//Tipo de comando ejecutado
                cnx.Open();//Abrir conexión de BD
                dr = cm.ExecuteReader();
                listaInicio = new List<Inicio>();//Lista de Inicio

                while (dr.Read())//Recorre cada registros
                {
                    Inicio cs = new Inicio();
                    cs.UserID= Convert.ToInt32(dr["UserID"].ToString());
                    cs.LoginName = dr["LoginName"].ToString();
                    cs.Password = dr["Password"].ToString();
                
                    listaInicio.Add(cs);//Agrega registro encontrado a lista
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();//Muestra mensaje en caso de ERROR
                listaInicio = null;
            }
            finally
            {
                cm.Connection.Close();//Cierre de conexión de BD
            }
            return listaInicio;//Regresa lista
        }
    }

}