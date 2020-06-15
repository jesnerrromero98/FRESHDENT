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

namespace CapaPresentacionEspecialidad
{
    public partial class fEspecialidad : Form
    {
        logicaNegocioEspecialidad logicaNEs = new logicaNegocioEspecialidad();

        public fEspecialidad()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Especialidad objetoEspecialidad = new Especialidad();
                    objetoEspecialidad.NombreEspecialidad = textBoxNombreEspecialidad.Text;
                    objetoEspecialidad.DescpEspecialidad = textBoxDescpEspecialidad.Text;

                    if (logicaNEs.insertarEspecialidad(objetoEspecialidad) > 0)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewEspecialidad.DataSource = logicaNEs.listarEspecialidad();
                        textBoxNombreEspecialidad.Text = "";
                        textBoxDescpEspecialidad.Text = "";
                        tabEspecialidad.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Especialidad");
                    }
                }
                if (buttonGuardar.Text == "Actualizar")
                {
                    Especialidad objetoEspecialidad = new Especialidad();

                    objetoEspecialidad.IdEspecialidad = Convert.ToInt32(textBoxIDEspecialidad.Text);
                    objetoEspecialidad.NombreEspecialidad = textBoxNombreEspecialidad.Text;
                    objetoEspecialidad.DescpEspecialidad = textBoxDescpEspecialidad.Text;

                    if (logicaNEs.editarEspecialidad(objetoEspecialidad) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dataGridViewEspecialidad.DataSource = logicaNEs.listarEspecialidad();

                        textBoxNombreEspecialidad.Text = "";
                        textBoxDescpEspecialidad.Text = "";
                        tabEspecialidad.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Especialidad");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void fEspecialidad_Load(object sender, EventArgs e)
        {
            textBoxIDEspecialidad.Visible = false;
            labelIDEspecialidad.Visible = false;
            dataGridViewEspecialidad.DataSource = logicaNEs.listarEspecialidad();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxIDEspecialidad.Visible = true;
            textBoxIDEspecialidad.Enabled = false;
            labelIDEspecialidad.Visible = true;

            textBoxIDEspecialidad.Text = dataGridViewEspecialidad.CurrentRow.Cells["IdEspecialidad"].Value.ToString();
            textBoxNombreEspecialidad.Text = dataGridViewEspecialidad.CurrentRow.Cells["NombreEspecialidad"].Value.ToString();
            textBoxDescpEspecialidad.Text = dataGridViewEspecialidad.CurrentRow.Cells["DescpEspecialidad"].Value.ToString();

            tabEspecialidad.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }



        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Especialidad> listaEspecialidad = logicaNEs.buscarEspecialidad(textBoxBuscar.Text);
            dataGridViewEspecialidad.DataSource = listaEspecialidad;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            int codigoEs = Convert.ToInt32(dataGridViewEspecialidad.CurrentRow.Cells["IdEspecialidad"].Value.ToString());
            try
            {
                if (logicaNEs.eliminarEspecialidad(codigoEs) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dataGridViewEspecialidad.DataSource = logicaNEs.listarEspecialidad();
                }
            }
            catch
            {

                MessageBox.Show("Error al eliminar Especialidad");
            }
        }
    }
}
