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

namespace CapaPresentacionMedico
{
    public partial class fMedico : Form
    {

        logicaNegocioMedico logicaNM = new logicaNegocioMedico();//Instanciando la clase

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
                    Medico objetoMedico = new Medico();//Instanciando la clase

                    //Los datos ingresados en el textbox son asignado a los atributos de la clase Médico
                    objetoMedico.NombreMedico = textBoxNombreMedico.Text;
                    objetoMedico.Telefono_Celular = Convert.ToInt32(textBoxTelefono_CelularMedico.Text);
                    objetoMedico.IdEspecialidad = Convert.ToInt32(textBoxIDEspecialidadMedico.Text);

                    if (logicaNM.insertarMedico(objetoMedico) > 0)
                    {
                        MessageBox.Show("Agregado con exito");

                        //Los datos después de ser asignado por cada atributo, se registra a la base de datos
                        dataGridViewMedico.DataSource = logicaNM.listarMedico();//Muestra datos registrados
                        textBoxNombreMedico.Text = "";
                        textBoxTelefono_CelularMedico.Text = "";
                        textBoxIDEspecialidadMedico.Text = "";

                        //Una vez realizado lo anterior, por si solo se pasa al segundo menú permitiendo observar la información
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

                    // El dato cambiado en el textbox se actualiza los atributos de la clase Especialidad
                    objetoMedico.IdMedico = Convert.ToInt32(textBoxIDMedico.Text);
                    objetoMedico.NombreMedico = textBoxNombreMedico.Text;
                    objetoMedico.Telefono_Celular = Convert.ToInt32(textBoxTelefono_CelularMedico.Text);
                    objetoMedico.IdEspecialidad = Convert.ToInt32(textBoxIDEspecialidadMedico.Text);

                    if (logicaNM.editarMedico(objetoMedico) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");

                        //El dato después de ser actualizado, se registra en la base datos
                        dataGridViewMedico.DataSource = logicaNM.listarMedico();//Muestra datos registrados
                        textBoxNombreMedico.Text = "";
                        textBoxTelefono_CelularMedico.Text = "";
                        textBoxIDEspecialidadMedico.Text = "";

                        //Una vez realizado lo anterior, por si solo se pasa al segundo menú permitiendo observar la información
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
            //Oculta el campo ID
            textBoxIDMedico.Visible = false;
            labelIDMedico.Visible = false;
            dataGridViewMedico.DataSource = logicaNM.listarMedico();//Muestra datos registrados
            dataGridViewMedico.Columns[0].Visible = false;
            dataGridViewMedico.Columns[3].Visible = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Muestra el campo ID pero no permite edición
            textBoxIDMedico.Visible = true;
            textBoxIDMedico.Enabled = false;
            labelIDMedico.Visible = true;

            //Ubica los datos en los campos donde se ingresó para su modificación o actualización
            textBoxIDMedico.Text = dataGridViewMedico.CurrentRow.Cells["IdMedico"].Value.ToString();
            textBoxNombreMedico.Text = dataGridViewMedico.CurrentRow.Cells["NombreMedico"].Value.ToString();
            textBoxTelefono_CelularMedico.Text = dataGridViewMedico.CurrentRow.Cells["Telefono_Celular"].Value.ToString();
            textBoxIDEspecialidadMedico.Text = dataGridViewMedico.CurrentRow.Cells["IdEspecialidad"].Value.ToString();

            // Por si solo se pasa al primer menú permitiendo observar la información en los campos ubicados
            tabMedico.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Indica que el registro seleccionado se eliminará utilizando el ID como referencia
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
            //Indica que el dato a buscar te lo presentará a medida de su busqueda
            List<Medico> listaMedico = logicaNM.buscarMedico(textBoxBuscar.Text);
            dataGridViewMedico.DataSource = listaMedico;
        }

        private void dataGridViewMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
