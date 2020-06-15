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

namespace CapaPresentacionCita
{
    public partial class fCita : Form
    {
        logicaNegocioCita logicaNCt = new logicaNegocioCita();

        public fCita()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Cita objetoCita = new Cita();
                    objetoCita.FechaCita = Convert.ToDateTime(textBoxFechaCita.Text);
                    objetoCita.HoraDisponible = Convert.ToDateTime(textBoxHoraDisponibleCita.Text);
                    objetoCita.Precio = Convert.ToInt32(textBoxPrecioCita.Text);
                    objetoCita.Tipo = textBoxTipoCita.Text;
                    objetoCita.IdExpediente = Convert.ToInt32(textBoxIDExpedienteCita.Text);
                    objetoCita.IdMedico = Convert.ToInt32(textBoxIDMedicoCita.Text);

                    if (logicaNCt.insertarCita(objetoCita) > 0)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewCita.DataSource = logicaNCt.listarCita();
                        textBoxFechaCita.Text = "";
                        textBoxHoraDisponibleCita.Text = "";
                        textBoxPrecioCita.Text = "";
                        textBoxTipoCita.Text = "";
                        textBoxIDExpedienteCita.Text = "";
                        textBoxIDMedicoCita.Text = "";
                        tabCita.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Cita");
                    }
                }
                if (buttonGuardar.Text == "Actualizar")
                {
                    Cita objetoCita = new Cita();
                    objetoCita.IdCita = Convert.ToInt32(textBoxIDCita.Text);
                    objetoCita.FechaCita = Convert.ToDateTime(textBoxFechaCita.Text);
                    objetoCita.HoraDisponible = Convert.ToDateTime(textBoxHoraDisponibleCita.Text);
                    objetoCita.Precio = Convert.ToInt32(textBoxPrecioCita.Text);
                    objetoCita.Tipo = textBoxTipoCita.Text;
                    objetoCita.IdExpediente = Convert.ToInt32(textBoxIDExpedienteCita.Text);
                    objetoCita.IdMedico = Convert.ToInt32(textBoxIDMedicoCita.Text);

                    if (logicaNCt.editarCita(objetoCita) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dataGridViewCita.DataSource = logicaNCt.listarCita();
                        textBoxFechaCita.Text = "";
                        textBoxHoraDisponibleCita.Text = "";
                        textBoxPrecioCita.Text = "";
                        textBoxTipoCita.Text = "";
                        textBoxIDExpedienteCita.Text = "";
                        textBoxIDMedicoCita.Text = "";
                        tabCita.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Cita");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoCt = Convert.ToInt32(dataGridViewCita.CurrentRow.Cells["IdCita"].Value.ToString());
            try
            {
                if (logicaNCt.eliminarCita(codigoCt) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dataGridViewCita.DataSource = logicaNCt.listarCita();
                }
            }
            catch
            {

                MessageBox.Show("Error al eliminar Cita");
            }
        }

        private void fCita_Load(object sender, EventArgs e)
        {
            textBoxIDCita.Visible = false;
            labelIDCita.Visible = false;
            dataGridViewCita.DataSource = logicaNCt.listarCita();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxIDCita.Visible = true;
            textBoxIDCita.Enabled = false;
            labelIDCita.Visible = true;

            textBoxIDCita.Text = dataGridViewCita.CurrentRow.Cells["IdCita"].Value.ToString();
            textBoxFechaCita.Text = dataGridViewCita.CurrentRow.Cells["FechaCita"].Value.ToString();
            textBoxHoraDisponibleCita.Text = dataGridViewCita.CurrentRow.Cells["HoraDisponible"].Value.ToString();
            textBoxPrecioCita.Text = dataGridViewCita.CurrentRow.Cells["Precio"].Value.ToString();
            textBoxTipoCita.Text = dataGridViewCita.CurrentRow.Cells["Tipo"].Value.ToString();
            textBoxIDExpedienteCita.Text = dataGridViewCita.CurrentRow.Cells["IdExpediente"].Value.ToString();
            textBoxIDMedicoCita.Text = dataGridViewCita.CurrentRow.Cells["IdMedico"].Value.ToString();

            tabCita.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Cita> listaCita = logicaNCt.buscarCita(textBoxBuscar.Text);
            dataGridViewCita.DataSource = listaCita;
        }
    }
}
