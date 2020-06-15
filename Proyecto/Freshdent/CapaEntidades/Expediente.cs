using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Expediente
    {
        //Se definieron los atributos junto con sus propiedades tal como se encuentra en la tabla Expediente de la base de datos.
        public int IdExpediente { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public int Telefono_Celular { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
    }
}
