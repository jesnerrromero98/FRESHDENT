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



namespace capapresentacionWF
{
    public partial class Fcitas : Form
    {
        logicaNegocioCita logicaNCt = new logicaNegocioCita();//Instanciando la clase
        public Fcitas()
        {
            InitializeComponent();
        }



        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Cita objetoCita = new Cita();//Instanciando la clase

                    //Los datos ingresados en el textbox son asignado a los atributos de la clase Cita
                    objetoCita.FechaCita = Convert.ToDateTime(textBoxFechaCita.Text);
                    objetoCita.HoraDisponible = Convert.ToDateTime(textBoxHoraDisponibleCita.Text);
                    objetoCita.Precio = Convert.ToInt32(textBoxPrecioCita.Text);
                    objetoCita.Tipo = textBoxTipoCita.Text;
                    objetoCita.IdExpediente = Convert.ToInt32(textBoxIDExpedienteCita.Text);
                    objetoCita.IdMedico = Convert.ToInt32(textBoxIDMedicoCita.Text);

                    if (logicaNCt.insertarCita(objetoCita) > 0)
                    {
                        MessageBox.Show("Agregado con exito");

                        //Los datos después de ser asignado por cada atributo, se registra a la base de datos
                        dataGridViewCita.DataSource = logicaNCt.listarCita();//Muestra datos registrados
                        textBoxFechaCita.Text = "";
                        textBoxHoraDisponibleCita.Text = "";
                        textBoxPrecioCita.Text = "";
                        textBoxTipoCita.Text = "";
                        textBoxIDExpedienteCita.Text = "";
                        textBoxIDMedicoCita.Text = "";

                        //Una vez realizado lo anterior, por si solo se pasa al segundo menú permitiendo observar la información
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

                    // El dato cambiado en el textbox se actualiza los atributos de la clase Cita
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

                        //El dato después de ser actualizado, se registra en la base datos
                        dataGridViewCita.DataSource = logicaNCt.listarCita();//Muestra datos registrados
                        textBoxFechaCita.Text = "";
                        textBoxHoraDisponibleCita.Text = "";
                        textBoxPrecioCita.Text = "";
                        textBoxTipoCita.Text = "";
                        textBoxIDExpedienteCita.Text = "";
                        textBoxIDMedicoCita.Text = "";

                        //Una vez realizado lo anterior, por si solo se pasa al segundo menú permitiendo observar la información
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

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Muestra el campo ID pero no permite edición
            textBoxIDCita.Visible = true;
            textBoxIDCita.Enabled = false;
            labelIDCita.Visible = true;


            //Ubica los datos en los campos donde se ingresó para su modificación o actualización
            textBoxIDCita.Text = dataGridViewCita.CurrentRow.Cells["IdCita"].Value.ToString();
            textBoxFechaCita.Text = dataGridViewCita.CurrentRow.Cells["FechaCita"].Value.ToString();
            textBoxHoraDisponibleCita.Text = dataGridViewCita.CurrentRow.Cells["HoraDisponible"].Value.ToString();
            textBoxPrecioCita.Text = dataGridViewCita.CurrentRow.Cells["Precio"].Value.ToString();
            textBoxTipoCita.Text = dataGridViewCita.CurrentRow.Cells["Tipo"].Value.ToString();
            textBoxIDExpedienteCita.Text = dataGridViewCita.CurrentRow.Cells["IdExpediente"].Value.ToString();
            textBoxIDMedicoCita.Text = dataGridViewCita.CurrentRow.Cells["IdMedico"].Value.ToString();

            // Por si solo se pasa al primer menú permitiendo observar la información en los campos ubicados
            tabCita.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        //private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        //{
        //    //Indica que el dato a buscar te lo presentará a medida de su busqueda
        //    List<Cita> listaCita = logicaNCt.buscarCita(textBoxBuscar.Text);
        //    dataGridViewCita.DataSource = listaCita;
        //}
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void Fcitas_Load_1(object sender, EventArgs e)
        {
            textBoxIDCita.Visible = false;
            labelIDCita.Visible = false;
            dataGridViewCita.DataSource = logicaNCt.listarCita();//Muestra datos registrados
            dataGridViewCita.Columns[0].Visible = false;
            dataGridViewCita.Columns[5].Visible = false;
            dataGridViewCita.Columns[6].Visible = false;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBuscar_TextChanged_1(object sender, EventArgs e)
        {
            List<Cita> listaCita = logicaNCt.buscarCita(textBoxBuscar.Text);
            dataGridViewCita.DataSource = listaCita;
        }
    }
}

