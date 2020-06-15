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

namespace CapaPresentacionExpediente
{
    public partial class fExpediente : Form
    {

        logicaNegocioExpediente logicaNE = new logicaNegocioExpediente();

        public fExpediente()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Expediente objetoExpediente = new Expediente();

                    objetoExpediente.Cedula = textBoxCedulaExpediente.Text;
                    objetoExpediente.Nombres = textBoxNombreExpediente.Text;
                    objetoExpediente.Apellidos = textBoxApellidoExpediente.Text;
                    objetoExpediente.Fecha_Nacimiento =textBoxFecha_NacimientoExpediente.Text;
                    objetoExpediente.Telefono_Celular = Convert.ToInt32(textBoxTelefono_CelularExpediente.Text);
                    objetoExpediente.Municipio = textBoxMunicipioExpediente.Text;
                    objetoExpediente.Departamento = textBoxDepartamentoExpediente.Text;

                    if (logicaNE.insertarExpediente(objetoExpediente)>0)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridView1.DataSource = logicaNE.listarExpediente();
                        textBoxCedulaExpediente.Text = "";
                        textBoxNombreExpediente.Text = "";
                        textBoxApellidoExpediente.Text = "";
                        textBoxFecha_NacimientoExpediente.Text = "";
                        textBoxTelefono_CelularExpediente.Text = "";
                        textBoxMunicipioExpediente.Text = "";
                        textBoxDepartamentoExpediente.Text = "";

                        tabExpediente.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar expediente");
                    }
                }
                if (buttonGuardar.Text == "Actualizar")
                {
                    Expediente objetoExpediente = new Expediente();

                    objetoExpediente.IdExpediente = Convert.ToInt32(textBoxIDExpediente.Text);
                    objetoExpediente.Cedula = textBoxCedulaExpediente.Text;
                    objetoExpediente.Nombres = textBoxNombreExpediente.Text;
                    objetoExpediente.Apellidos = textBoxApellidoExpediente.Text;
                    objetoExpediente.Fecha_Nacimiento = textBoxFecha_NacimientoExpediente.Text;
                    objetoExpediente.Telefono_Celular = Convert.ToInt32(textBoxTelefono_CelularExpediente.Text);
                    objetoExpediente.Municipio = textBoxMunicipioExpediente.Text;
                    objetoExpediente.Departamento = textBoxDepartamentoExpediente.Text;

                    if (logicaNE.editarExpediente(objetoExpediente)>0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dataGridView1.DataSource = logicaNE.listarExpediente();
                        textBoxCedulaExpediente.Text = "";
                        textBoxNombreExpediente.Text = "";
                        textBoxApellidoExpediente.Text = "";
                        textBoxFecha_NacimientoExpediente.Text = "";
                        textBoxTelefono_CelularExpediente.Text = "";
                        textBoxMunicipioExpediente.Text = "";
                        textBoxDepartamentoExpediente.Text = "";
                        tabExpediente.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Expediente");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void fExpediente_Load(object sender, EventArgs e)
        {
            textBoxIDExpediente.Visible = false;
            labelIDExpediente.Visible = false;
            dataGridView1.DataSource = logicaNE.listarExpediente();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxIDExpediente.Visible = true;
            textBoxIDExpediente.Enabled = false;
            labelIDExpediente.Visible = true;

            textBoxIDExpediente.Text = dataGridView1.CurrentRow.Cells["IdExpediente"].Value.ToString();
            textBoxCedulaExpediente.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
            textBoxNombreExpediente.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
            textBoxApellidoExpediente.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
            textBoxFecha_NacimientoExpediente.Text = dataGridView1.CurrentRow.Cells["Fecha_Nacimiento"].Value.ToString();
            textBoxTelefono_CelularExpediente.Text = dataGridView1.CurrentRow.Cells["Telefono_Celular"].Value.ToString();
            textBoxMunicipioExpediente.Text = dataGridView1.CurrentRow.Cells["Municipio"].Value.ToString();
            textBoxDepartamentoExpediente.Text = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();

            tabExpediente.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoE = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdExpediente"].Value.ToString());
            try
            {
                if (logicaNE.eliminarExpediente(codigoE)>0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dataGridView1.DataSource = logicaNE.listarExpediente();
                }
            }
            catch
            {

                MessageBox.Show("Error al eliminar Expediente");
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Expediente> listaExpediente = logicaNE.buscarExpediente(textBoxBuscar.Text);
            dataGridView1.DataSource = listaExpediente;
        }
    }
}
