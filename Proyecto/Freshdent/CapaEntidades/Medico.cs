using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Medico
    {
        //Se definieron los atributos junto con sus propiedades tal como se encuentra en la tabla Médico de la base de datos.
        public int IdMedico { get; set; }
        public string NombreMedico { get; set; }
        public int Telefono_Celular { get; set; }
        public int IdEspecialidad { get; set; }
        //Agreamos este campo con el fin de presentarlo en el data grid
        //si deseamos presentar mas campos en el datagrid debemos agregarlos aca
        //realizar la consulta en sql correctamente y configurar la capa de datos
        public string NombreEspecialidad { get; set; }
    }
}
