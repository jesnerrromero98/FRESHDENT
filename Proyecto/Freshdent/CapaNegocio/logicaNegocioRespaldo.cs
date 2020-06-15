using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;//Referencia

namespace CapaNegocio
{
    public class logicaNegocioRespaldo
    {
        accesoDatosRespaldoBD rbd = new accesoDatosRespaldoBD();//Instancia

        //Regresa lo que devuelve el método
        public int respaldarBD()
        {
            return rbd.respaldarBD();
        }
    }
}
