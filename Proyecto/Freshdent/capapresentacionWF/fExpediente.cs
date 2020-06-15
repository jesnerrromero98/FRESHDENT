using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;//Referencia
using CapaNegocio;//Referencia

namespace CapaPresentacionExpediente
{
    public partial class fExpediente : Form
    {

        logicaNegocioExpediente logicaNE = new logicaNegocioExpediente();//Instanciando la clase

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
                    Expediente objetoExpediente = new Expediente();//Instanciando la clase

                    //Los datos ingresados en el textbox son asignado a los atributos de la clase Expediente
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

                        //Los datos después de ser asignado por cada atributo, se registra a la base de datos
                        dataGridView1.DataSource = logicaNE.listarExpediente();//Muestra datos registrados
                        textBoxCedulaExpediente.Text = "";
                        textBoxNombreExpediente.Text = "";
                        textBoxApellidoExpediente.Text = "";
                        textBoxFecha_NacimientoExpediente.Text = "";
                        textBoxTelefono_CelularExpediente.Text = "";
                        textBoxMunicipioExpediente.Text = "";
                        textBoxDepartamentoExpediente.Text = "";

                        //Una vez realizado lo anterior, por si solo se pasa al segundo menú permitiendo observar la información
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

                    //El dato cambiado en el textbox se actualiza los atributos de la clase Expediente
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

                        //El dato después de ser actualizado, se registra en la base datos
                        dataGridView1.DataSource = logicaNE.listarExpediente();//Muestra datos registrados
                        textBoxCedulaExpediente.Text = "";
                        textBoxNombreExpediente.Text = "";
                        textBoxApellidoExpediente.Text = "";
                        textBoxFecha_NacimientoExpediente.Text = "";
                        textBoxTelefono_CelularExpediente.Text = "";
                        textBoxMunicipioExpediente.Text = "";
                        textBoxDepartamentoExpediente.Text = "";

                        //Una vez realizado lo anterior, por si solo se pasa al segundo menú permitiendo observar la información con su actualización
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
            //Oculta el campo ID
            textBoxIDExpediente.Visible = false;
            labelIDExpediente.Visible = false;
            dataGridView1.DataSource = logicaNE.listarExpediente();//Muestra datos registrados
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Muestra el campo ID pero no permite edición
            textBoxIDExpediente.Visible = true;
            textBoxIDExpediente.Enabled = false;
            labelIDExpediente.Visible = true;

            //Ubica los datos en los campos donde se ingresó para su modificación o actualización
            textBoxIDExpediente.Text = dataGridView1.CurrentRow.Cells["IdExpediente"].Value.ToString();
            textBoxCedulaExpediente.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
            textBoxNombreExpediente.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
            textBoxApellidoExpediente.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
            textBoxFecha_NacimientoExpediente.Text = dataGridView1.CurrentRow.Cells["Fecha_Nacimiento"].Value.ToString();
            textBoxTelefono_CelularExpediente.Text = dataGridView1.CurrentRow.Cells["Telefono_Celular"].Value.ToString();
            textBoxMunicipioExpediente.Text = dataGridView1.CurrentRow.Cells["Municipio"].Value.ToString();
            textBoxDepartamentoExpediente.Text = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();

            //Por si solo se pasa al primer menú permitiendo observar la información en los campos ubicados
            tabExpediente.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Indica que el registro seleccionado se eliminará utilizando el ID como referencia
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
            //Indica que el dato a buscar te lo presentará a medida de su busqueda
            List<Expediente> listaExpediente = logicaNE.buscarExpediente(textBoxBuscar.Text);
            dataGridView1.DataSource = listaExpediente;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Expediente> listaExpediente = logicaNE.buscarExpediente(textBoxBuscar.Text);
            dataGridView1.DataSource = listaExpediente;
        }
    }
}
