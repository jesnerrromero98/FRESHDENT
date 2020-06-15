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

namespace CapaPresentacionMedico
{
    public partial class fMedico : Form
    {

        logicaNegocioMedico logicaNM = new logicaNegocioMedico();

        public fMedico()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Medico objetoMedico = new Medico();
                    objetoMedico.NombreMedico = textBoxNombreMedico.Text;
                    objetoMedico.Telefono_Celular = Convert.ToInt32(textBoxTelefono_CelularMedico.Text);
                    objetoMedico.IdEspecialidad = Convert.ToInt32(textBoxIDEspecialidadMedico.Text);

                    if (logicaNM.insertarMedico(objetoMedico) > 0)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewMedico.DataSource = logicaNM.listarMedico();
                        textBoxNombreMedico.Text = "";
                        textBoxTelefono_CelularMedico.Text = "";
                        textBoxIDEspecialidadMedico.Text = "";
                        tabMedico.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Medico");
                    }
                }
                if (buttonGuardar.Text == "Actualizar")
                {
                    Medico objetoMedico = new Medico ();

                    objetoMedico.IdMedico = Convert.ToInt32(textBoxIDMedico.Text);
                    objetoMedico.NombreMedico = textBoxNombreMedico.Text;
                    objetoMedico.Telefono_Celular = Convert.ToInt32(textBoxTelefono_CelularMedico.Text);
                    objetoMedico.IdEspecialidad = Convert.ToInt32(textBoxIDEspecialidadMedico.Text);

                    if (logicaNM.editarMedico(objetoMedico) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dataGridViewMedico.DataSource = logicaNM.listarMedico();
                        textBoxNombreMedico.Text = "";
                        textBoxTelefono_CelularMedico.Text = "";
                        textBoxIDEspecialidadMedico.Text = "";
                        tabMedico.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Medico");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void fMedico_Load(object sender, EventArgs e)
        {
            textBoxIDMedico.Visible = false;
            labelIDMedico.Visible = false;
            dataGridViewMedico.DataSource = logicaNM.listarMedico();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxIDMedico.Visible = true;
            textBoxIDMedico.Enabled = false;
            labelIDMedico.Visible = true;

            textBoxIDMedico.Text = dataGridViewMedico.CurrentRow.Cells["IdMedico"].Value.ToString();
            textBoxNombreMedico.Text = dataGridViewMedico.CurrentRow.Cells["NombreMedico"].Value.ToString();
            textBoxTelefono_CelularMedico.Text = dataGridViewMedico.CurrentRow.Cells["Telefono_Celular"].Value.ToString();
            textBoxIDEspecialidadMedico.Text = dataGridViewMedico.CurrentRow.Cells["IdEspecialidad"].Value.ToString();

            tabMedico.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoM = Convert.ToInt32(dataGridViewMedico.CurrentRow.Cells["IdMedico"].Value.ToString());
            try
            {
                if (logicaNM.eliminarMedico(codigoM) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dataGridViewMedico.DataSource = logicaNM.listarMedico();
                }
            }
            catch
            {

                MessageBox.Show("Error al eliminar Medico");
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Medico> listaMedico = logicaNM.buscarMedico(textBoxBuscar.Text);
            dataGridViewMedico.DataSource = listaMedico;
        }
    }
}
