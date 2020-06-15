using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;//Referencia
using CapaEntidades;//Referencia

namespace CapaNegocio
{
    public class logicaNegocioCita
    {
        accesoDatosCita adCt = new accesoDatosCita();//Instancia

        //Regresa lo que devuelve cada método
        public int insertarCita(Cita ct)
        {
            return adCt.insertarCita(ct);
        }
        public List<Cita> listarCita()
        {
            return adCt.listarCita();
        }
        public int eliminarCita(int IdC)
        {
            return adCt.eliminarCita(IdC);
        }
        public int editarCita(Cita ct)
        {
            return adCt.editarCita(ct);
        }
        public List<Cita> buscarCita(string dato)
        {
            return adCt.buscarCita(dato);
        }
    }
}
