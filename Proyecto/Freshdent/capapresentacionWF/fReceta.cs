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

namespace CapaPresentacionReceta
{
    public partial class fReceta : Form
    {
        logicaNegocioReceta logicaNR = new logicaNegocioReceta();//Instanciando la clase

        public fReceta()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Receta objetoReceta = new Receta();//Instanciando la clase

                    //Los datos ingresados en el textbox son asignado a los atributos de la clase Receta
                    objetoReceta.Nombre = textBoxNombreReceta.Text;
                    objetoReceta.Presentacion =textBoxPresentacionReceta.Text;
                    objetoReceta.Cantidad = Convert.ToInt32(textBoxCantidadReceta.Text);
                    objetoReceta.Descripcion = textBoxDescripcionReceta.Text;

                    if (logicaNR.insertarReceta(objetoReceta) > 0)
                    {
                        MessageBox.Show("Agregado con exito");

                        //Los datos después de ser asignado por cada atributo, se registra a la base de datos
                        dataGridViewReceta.DataSource = logicaNR.listarReceta();//Muestra datos registrados
                        textBoxNombreReceta.Text = "";
                        textBoxPresentacionReceta.Text = "";
                        textBoxCantidadReceta.Text = "";
                        textBoxDescripcionReceta.Text = "";

                        //Una vez realizado lo anterior, por si solo se pasa al segundo menú permitiendo observar la información
                        tabReceta.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Receta");
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
            //Indica que el registro seleccionado se eliminará utilizando el ID como referencia
            int codigoR = Convert.ToInt32(dataGridViewReceta.CurrentRow.Cells["IdReceta"].Value.ToString());
            try
            {
                if (logicaNR.eliminarReceta(codigoR) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dataGridViewReceta.DataSource = logicaNR.listarReceta();
                }
            }
            catch
            {

                MessageBox.Show("Error al eliminar Receta");
            }
        }

        private void fReceta_Load(object sender, EventArgs e)
        {
            //Oculta el campo ID
            textBoxIDReceta.Visible = false;
            labelIDReceta.Visible = false;
            dataGridViewReceta.DataSource = logicaNR.listarReceta();//Muestra datos registrados
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
