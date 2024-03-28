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
   
    public partial class Registro : Form
    {
        public string nombreMascota ="";
        public string raza = "";
        public string color = "";
        public string alergico = "";
        public string atencionEspecial ="";
        public string nombreDuenio = "";
        public int celDuenio = 0;
        public string observaciones = "";


        //llamamos los controles y modelos
        MascotaBDD oMascotaBDD;
        DuenioBDD oDuenioBDD;
        public Registro()
        {
            //inicializamos
            oMascotaBDD = new MascotaBDD();
            oDuenioBDD = new DuenioBDD();
            InitializeComponent();
        }

        /// <summary>
        /// BOTON LIMPIAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        /// <summary>
        /// BOTON GUARDAR DATOS
        /// Guarda la informacion ingresada en la interfaz en la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGuardar_Click(object sender, EventArgs e)
        {

            //Toma la informacion de la interfaz
            //tomarDatos();
            ConexionBDD conexion = new ConexionBDD();

          //  oDuenioBDD.Agregar(tomarDatos());

           DuenioBLL objDuenioBLL = new DuenioBLL();
           objDuenioBLL = tomarDatos();
          // oMascotaBDD.Agregar(tomarDatos(objDuenioBLL));
        //   MessageBox.Show("resultado:" + oMascotaBDD.Agregar(tomarDatos(objDuenioBLL)));
            MessageBox.Show("resultado:" + oDuenioBDD.existe(objDuenioBLL));
            LimpiarCampos();
        }


        private MascotaBLL tomarDatos(DuenioBLL objDuenioBLL)
        {
            MascotaBLL objMascotaBLL = new MascotaBLL();
            

            objMascotaBLL.Nombre = txtNombreMascota.Text.ToString();
            objMascotaBLL.Raza = txtRaza.Text.ToString();
            objMascotaBLL.Color = txtColor.Text.ToString();
            objMascotaBLL.Alergico = comboAlergico.Text.ToString();
            objMascotaBLL.Atencion_especial = comboAtencion.Text.ToString();
            objMascotaBLL.Observaciones = richObservaciones.Text.ToString();
            objMascotaBLL.UnDuenio = objDuenioBLL;

            return objMascotaBLL;
        }
        private DuenioBLL tomarDatos()
        {
            DuenioBLL objDuenioBLL = new DuenioBLL();


            //infoDuenio

            objDuenioBLL.Dni = txtDniDuenio.Text.ToString();
            objDuenioBLL.Nombre = txtNombreDuenio.Text.ToString();
            objDuenioBLL.CelDuenio = txtCelDuenio.Text.ToString();

            return objDuenioBLL;
        }

        public void LimpiarCampos()
        {
            txtNombreMascota.Text= " ";
            txtRaza.Text = "";
            txtColor.Text = "";
            comboAlergico.Text = "";
            comboAtencion.Text = "";
            txtNombreDuenio.Text = "";
            txtCelDuenio.Text ="";
            richObservaciones.Clear(); //OJO CON ESTE


        }

    }
}
