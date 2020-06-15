using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;//Referencia
using CapaEntidades;//Referencia

namespace CapaNegocio
{
    public class logicaNegocioConsulta
    {
        accesoDatosConsulta adCs = new accesoDatosConsulta();//Instancia

        //Regresa lo que devuelve cada método
        public int insertarConsulta(Consulta cs)
        {
            return adCs.insertarConsulta(cs);
        }
        public List<Consulta> listarConsulta()
        {
            return adCs.listarConsulta();
        }
        public int eliminarConsulta(int IdCons)
        {
            return adCs.eliminarConsulta(IdCons);
        }
    }
}
