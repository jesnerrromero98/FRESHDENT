using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;//Referencia

namespace capapresentacionWF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void inicio_Click(object sender, EventArgs e)
        {
            try
            {
                logicaInicio inic = new logicaInicio();//Instanciando la clase

                /*Los datos ingresados para iniciar sesión se verifica si es igual a datos existente 
                 * que se encuentra en la base de datos para asi permitir el acceso o no*/
                var user = inic.IniciarSesion(usuario.Text, contraseña.Text);
                this.Visible = false;
                usuario.Clear();
                contraseña.Clear();

                config.UsuarioActual = user;

                registroMDI form = new registroMDI();
                form.ShowDialog();

                this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
