using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cita
    {
        //Se definieron los atributos junto con sus propiedades tal como se encuentra en la tabla Cita de la base de datos.
        public int IdCita { get; set; }
        public DateTime FechaCita { get; set; }
        public DateTime HoraDisponible { get; set; }
        public int Precio { get; set; }
        public string Tipo { get; set; }
        public int IdExpediente { get; set; }
        public int IdMedico { get; set; }
        //Agreamos este campo con el fin de presentarlo en el data grid
        //si deseamos presentar mas campos en el datagrid debemos agregarlos aca
        //realizar la consulta en sql correctamente y configurar la capa de datos
        public string NombreMedico { get; set; }
        public string Nombres { get; set; }
    }
}
