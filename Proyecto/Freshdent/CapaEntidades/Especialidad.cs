using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Especialidad
    {
        //Se definieron los atributos junto con sus propiedades tal como se encuentra en la tabla Especialidad de la base de datos.
        public int IdEspecialidad { get; set; }
        public string NombreEspecialidad { get; set; }
        public string DescpEspecialidad { get; set; }
    }
}
