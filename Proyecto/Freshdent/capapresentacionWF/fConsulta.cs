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

namespace CapaPresentacionConsulta
{
    public partial class fConsulta : Form
    {
        logicaNegocioConsulta logicaNCs = new logicaNegocioConsulta();//Instanciando la clase

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
                    Consulta objetoConsulta = new Consulta();//Instanciando la clase

                    //Los datos ingresados en el textbox son asignado a los atributos de la clase Consulta
                    objetoConsulta.Fecha = Convert.ToDateTime(textBoxFechaConsulta.Text);
                    objetoConsulta.Hora = Convert.ToDateTime(textBoxHoraConsulta.Text);
                    objetoConsulta.Sintoma = textBoxSintomaConsulta.Text;
                    objetoConsulta.Diagnostico = textBoxDiagnosticoConsulta.Text;
                    objetoConsulta.IdExpediente = Convert.ToInt32(textBoxIDExpedienteConsulta.Text);
                    objetoConsulta.IdMedico = Convert.ToInt32(textBoxIDMedicoConsulta.Text);

                    if (logicaNCs.insertarConsulta(objetoConsulta) > 0)
                    {
                        MessageBox.Show("Agregado con exito");

                        //Los datos después de ser asignado por cada atributo, se registra a la base de datos
                        dataGridViewConsulta.DataSource = logicaNCs.listarConsulta();//Muestra datos registrados
                        textBoxFechaConsulta.Text = "";
                        textBoxHoraConsulta.Text = "";
                        textBoxSintomaConsulta.Text = "";
                        textBoxDiagnosticoConsulta.Text = "";
                        textBoxIDExpedienteConsulta.Text = "";
                        textBoxIDMedicoConsulta.Text = "";

                        //Una vez realizado lo anterior, por si solo se pasa al segundo menú permitiendo observar la información
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
            //Indica que el registro seleccionado se eliminará utilizando el ID como referencia
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
            //Oculta el campo ID
            textBoxIDConsulta.Visible = false;
            labelIDConsulta.Visible = false;

           dataGridViewConsulta.DataSource = logicaNCs.listarConsulta();//Muestra datos registrados
           dataGridViewConsulta.Columns[0].Visible = false;
           dataGridViewConsulta.Columns[5].Visible = false;
           dataGridViewConsulta.Columns[6].Visible = false;
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
