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

namespace CapaPresentacionReceta
{
    public partial class fReceta : Form
    {
        logicaNegocioReceta logicaNR = new logicaNegocioReceta();

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
                    Receta objetoReceta = new Receta();
                    objetoReceta.Nombre = textBoxNombreReceta.Text;
                    objetoReceta.Presentacion =textBoxPresentacionReceta.Text;
                    objetoReceta.Cantidad = Convert.ToInt32(textBoxCantidadReceta.Text);
                    objetoReceta.Descripcion = textBoxDescripcionReceta.Text;

                    if (logicaNR.insertarReceta(objetoReceta) > 0)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewReceta.DataSource = logicaNR.listarReceta();
                        textBoxNombreReceta.Text = "";
                        textBoxPresentacionReceta.Text = "";
                        textBoxCantidadReceta.Text = "";
                        textBoxDescripcionReceta.Text = "";
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
            textBoxIDReceta.Visible = false;
            labelIDReceta.Visible = false;
            dataGridViewReceta.DataSource = logicaNR.listarReceta();
        }
    }
}
