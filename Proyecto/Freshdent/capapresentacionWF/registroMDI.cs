using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacionExpediente;//Referencia
using CapaPresentacionMedico;//Referencia
using CapaPresentacionConsulta;//Referencia
using CapaPresentacionReceta;//Referencia
using capapresentacionWF;//Referencia
using CapaPresentacionEspecialidad;//Referencia

namespace capapresentacionWF
{
    public partial class registroMDI : Form
    {

        public registroMDI()
        {
            InitializeComponent();
        }
        
        //Permitir acceso al formulario Expediente
        private void ExpedienteMenu_Click(object sender, EventArgs e)
        {
            var formulario = new fExpediente();
            formulario.MdiParent = this;
            formulario.Show();
        }

        //Permitir acceso al formulario Médico
        private void MedicoMenu_Click(object sender, EventArgs e)
        {
            var formulario = new fMedico();
            formulario.MdiParent = this;
            formulario.Show();
        }

        //Permitir acceso al formulario Consulta
        private void ConsultaMenu_Click(object sender, EventArgs e)
        {
            var formulario = new fConsulta();
            formulario.MdiParent = this;
            formulario.Show();
        }

        //Permitir acceso al formulario Especialidad
        private void EspecialidadMenu_Click(object sender, EventArgs e)
        {
            var formulario = new fEspecialidad();
            formulario.MdiParent = this;
            formulario.Show();
        }

        //Permitir acceso al formulario Receta
        private void RecetaMenu_Click(object sender, EventArgs e)
        {
            var formulario = new fReceta();
            formulario.MdiParent = this;
            formulario.Show();
        }

        //Permitir acceso al formulario Cita
        private void CitaMenu_Click(object sender, EventArgs e)
        {
            var formulario = new Fcitas();
            formulario.MdiParent = this;
            formulario.Show();
        }

        //permiso de los usuario 
        private void registroMDI_Load(object sender, EventArgs e)
        {
            this.Text = $"{this.Text} - {config.UsuarioActual.LoginName}";
            permisos();
        }

        //Indica que formulario tendrá acceso en base al tipo de usuario
        private void permisos()
        {
            switch (config.UsuarioActual.LoginName)
            {
                case "admin":
                    
                    ConsultaMenu.Visible = false;
                    RecetaMenu.Visible = false;
                    break;
                case "doctor":
                    ExpedienteMenu.Visible = false;
                    EspecialidadMenu.Visible = false;
                    MedicoMenu.Visible = false;
                    break;
            }
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
