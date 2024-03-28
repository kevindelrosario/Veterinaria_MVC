using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.BDD;

namespace Veterinaria
{
    public partial class Buscar : Form
    {
        MascotaBDD mascotaBDD;
        DuenioBDD duenioBDD;
        public Buscar()
        {
            mascotaBDD = new MascotaBDD();
            duenioBDD = new DuenioBDD();
            InitializeComponent();
            grilla.DataSource = mascotaBDD.MostrarMascotas().Tables[0];
        }

     

     
        private void grilla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            grilla.ClearSelection();

            if (indice >= 0) //para evitar los errores con los espacios vacios.
            {
                id_mascota.Text = grilla.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = grilla.Rows[indice].Cells[1].Value.ToString();
                txtRaza.Text = grilla.Rows[indice].Cells[2].Value.ToString();
                txtColor.Text = grilla.Rows[indice].Cells[3].Value.ToString();
                comboAlergia.Text = grilla.Rows[indice].Cells[4].Value.ToString();
                comboAtencion.Text = grilla.Rows[indice].Cells[5].Value.ToString();
                richObservacion.Text = grilla.Rows[indice].Cells[6].Value.ToString();
                txtDniDuenio.Text = grilla.Rows[indice].Cells[7].Value.ToString();

                //falta agregar este valor bien:
               // richDatosDuenio.AppendText(Convert.ToString(duenioBDD.BuscarDueniosString(txtDniDuenio.Text)));
               //activa los botones
               btnBorrar.Enabled = true;
                btnActualizar.Enabled = true;
            }

            }

        /// <summary>
        /// Abre una nueva pestaña y muestra el dueño de la mascota seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            mascotaBDD.Eliminar(Convert.ToInt32(id_mascota.Text));
            grilla.DataSource = mascotaBDD.MostrarMascotas().Tables[0];
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            id_mascota.Text = "";
            txtNombre.Text = "";
            txtRaza.Text = "";
            txtColor.Text = "";
            comboAlergia.Text = "";
            comboAtencion.Text = "";
            richObservacion.Text = "";
            txtDniDuenio.Text = "";
        }
    }
}
