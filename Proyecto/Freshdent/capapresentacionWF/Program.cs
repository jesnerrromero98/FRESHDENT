using CapaPresentacionConsulta;//Referencia
using CapaPresentacionEspecialidad;//Referencia
using CapaPresentacionExpediente;//Referencia
using CapaPresentacionMedico;//Referencia
using CapaPresentacionReceta;//Referencia
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacionWF
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new fExpediente());
          //Application.Run(new Fcitas());
            //   Application.Run(new fReceta());
            //Application.Run(new fMedico());
            // Application.Run(new fConsulta());
            //Application.Run(new fEspecialidad());
           Application.Run(new Login());
        }
    }
}
