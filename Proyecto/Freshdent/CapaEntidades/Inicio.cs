using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Inicio
    {
        //Se definieron los atributos junto con sus propiedades tal como se encuentra en la tabla Inicio de la base de datos.
        public int UserID { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
    }
}
