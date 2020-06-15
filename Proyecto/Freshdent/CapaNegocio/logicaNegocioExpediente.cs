using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;//Referencia
using CapaEntidades;//Referencia

namespace CapaNegocio
{
    public class logicaNegocioExpediente
    {
        accesoDatosExpediente adE = new accesoDatosExpediente();//Instancia

        //Regresa lo que devuelve cada método
        public int insertarExpediente(Expediente ex)
        {
            return adE.insertarExpediente(ex);
        }
        public List<Expediente> listarExpediente()
        {
            return adE.listarExpediente();
        }
        public int eliminarExpediente(int IdExped)
        {
            return adE.eliminarExpediente(IdExped);
        }
        public int editarExpediente(Expediente ex)
        {
            return adE.editarExpediente(ex);
        }
        public List<Expediente> buscarExpediente(string dato)
        {
            return adE.buscarExpediente(dato);
        }
    }
}
