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

namespace CapaPresentacionEspecialidad
{
    public partial class fEspecialidad : Form
    {
        logicaNegocioEspecialidad logicaNEs = new logicaNegocioEspecialidad();//Instanciando la clase

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
                    Especialidad objetoEspecialidad = new Especialidad();//Instanciando la clase

                    //Los datos ingresados en el textbox son asignado a los atributos de la clase Especialidad
                    objetoEspecialidad.NombreEspecialidad = textBoxNombreEspecialidad.Text;
                    objetoEspecialidad.DescpEspecialidad = textBoxDescpEspecialidad.Text;

                    if (logicaNEs.insertarEspecialidad(objetoEspecialidad) > 0)
                    {
                        MessageBox.Show("Agregado con exito");

                        //Los datos después de ser asignado por cada atributo, se registra a la base de datos
                        dataGridViewEspecialidad.DataSource = logicaNEs.listarEspecialidad();//Muestra datos registrados
                        textBoxNombreEspecialidad.Text = "";
                        textBoxDescpEspecialidad.Text = "";

                        //Una vez realizado lo anterior, por si solo se pasa al segundo menú permitiendo observar la información
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

                    // El dato cambiado en el textbox se actualiza los atributos de la clase Expediente
                    objetoEspecialidad.IdEspecialidad = Convert.ToInt32(textBoxIDEspecialidad.Text);
                    objetoEspecialidad.NombreEspecialidad = textBoxNombreEspecialidad.Text;
                    objetoEspecialidad.DescpEspecialidad = textBoxDescpEspecialidad.Text;

                    if (logicaNEs.editarEspecialidad(objetoEspecialidad) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");

                        //El dato después de ser actualizado, se registra en la base datos
                        dataGridViewEspecialidad.DataSource = logicaNEs.listarEspecialidad();//Muestra datos registrados
                        textBoxNombreEspecialidad.Text = "";
                        textBoxDescpEspecialidad.Text = "";

                        //Una vez realizado lo anterior, por si solo se pasa al segundo menú permitiendo observar la información con su actualización
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
            //Oculta el campo ID
            textBoxIDEspecialidad.Visible = false;
            labelIDEspecialidad.Visible = false;
            dataGridViewEspecialidad.DataSource = logicaNEs.listarEspecialidad();//Muestra datos registrados
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Muestra el campo ID pero no permite edición
            textBoxIDEspecialidad.Visible = true;
            textBoxIDEspecialidad.Enabled = false;
            labelIDEspecialidad.Visible = true;

            //Ubica los datos en los campos donde se ingresó para su modificación o actualización
            textBoxIDEspecialidad.Text = dataGridViewEspecialidad.CurrentRow.Cells["IdEspecialidad"].Value.ToString();
            textBoxNombreEspecialidad.Text = dataGridViewEspecialidad.CurrentRow.Cells["NombreEspecialidad"].Value.ToString();
            textBoxDescpEspecialidad.Text = dataGridViewEspecialidad.CurrentRow.Cells["DescpEspecialidad"].Value.ToString();

            // Por si solo se pasa al primer menú permitiendo observar la información en los campos ubicados
            tabEspecialidad.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }



        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            //Indica que el dato a buscar te lo presentará a medida de su busqueda
            List<Especialidad> listaEspecialidad = logicaNEs.buscarEspecialidad(textBoxBuscar.Text);
            dataGridViewEspecialidad.DataSource = listaEspecialidad;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            //Indica que el registro seleccionado se eliminará utilizando el ID como referencia
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
