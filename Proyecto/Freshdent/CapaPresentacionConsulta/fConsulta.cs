using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacionConsulta
{
    public partial class fConsulta : Form
    {
        logicaNegocioConsulta logicaNCs = new logicaNegocioConsulta();
        public fConsulta()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Consulta objetoConsulta = new Consulta();
                    objetoConsulta.Fecha = Convert.ToDateTime(textBoxFechaConsulta.Text);
                    objetoConsulta.Hora = Convert.ToDateTime(textBoxHoraConsulta.Text);
                    objetoConsulta.Sintoma = textBoxSintomaConsulta.Text;
                    objetoConsulta.Diagnostico = textBoxDiagnosticoConsulta.Text;
                    objetoConsulta.IdExpediente = Convert.ToInt32(textBoxIDExpedienteConsulta.Text);
                    objetoConsulta.IdMedico = Convert.ToInt32(textBoxIDMedicoConsulta.Text);

                    if (logicaNCs.insertarConsulta(objetoConsulta) > 0)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewConsulta.DataSource = logicaNCs.listarConsulta();
                        textBoxFechaConsulta.Text = "";
                        textBoxHoraConsulta.Text = "";
                        textBoxSintomaConsulta.Text = "";
                        textBoxDiagnosticoConsulta.Text = "";
                        textBoxIDExpedienteConsulta.Text = "";
                        textBoxIDMedicoConsulta.Text = "";
                        tabConsulta.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Consulta");
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoCs = Convert.ToInt32(dataGridViewConsulta.CurrentRow.Cells["IdConsulta"].Value.ToString());
            try
            {
                if (logicaNCs.eliminarConsulta(codigoCs) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dataGridViewConsulta.DataSource = logicaNCs.listarConsulta();
                }
            }
            catch
            {

                MessageBox.Show("Error al eliminar Consulta");
            }
        }

        private void fConsulta_Load(object sender, EventArgs e)
        {
            textBoxIDConsulta.Visible = false;
            labelIDConsulta.Visible = false;
            dataGridViewConsulta.DataSource = logicaNCs.listarConsulta();
        }
        
    }
}
