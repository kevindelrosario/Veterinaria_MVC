
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//PARA USAR VALORES DE OTRAS CARPETAS
using Veterinaria.BDD;
using Veterinaria;

namespace Veterinaria
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();

        
        }




    

        /// <summary>
        /// AGREGAR NUEVO REGISTRO A LA BASE DE DATOS
        /// Abre pestaña para agregar un nuevo perro a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRegistro_Click(object sender, EventArgs e)
        {
              openChildForm(new Registro());
           
       //     MessageBox.Show("coneccion:" + conexionBDD.pruebaConectar());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Buscar());
        }
    


    /******************************Funcion para el cambio de pantalla de los distintos botones************************************/
    private Form activeForm = null;

        /// <summary>
        /// NUEVA PESTAÑA MENU
        /// Maneja el cambio de la vista.
        /// </summary>
        /// <param name="childForm"></param>
        private void openChildForm(Form childForm)//toma el form indicado y lo muestra en el panel central...
        {
            if (activeForm != null) //cierra el ultimo panel que se haya abierto y muestra el
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm); //Es el panel principal donde apareceran las demas pestañas del menu.
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


}
}