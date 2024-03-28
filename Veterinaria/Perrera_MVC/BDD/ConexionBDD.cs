using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agragados 
using System.Data;
using MySql.Data.MySqlClient;

namespace Veterinaria.BDD
{
    class ConexionBDD
    {

        private string cadenaConexion = "Server=localhost;Database=perrera;Uid=kevin;password=1234";
        MySqlConnection Conexion;


        public MySqlConnection estableceConexion()
        {
            this.Conexion = new MySqlConnection(this.cadenaConexion);
            return this.Conexion;
        }

        /// <summary>
        /// PARA COMPROBAR SI SE CONECTO CORRECTAMENTE.
        /// </summary>
        /// <returns></returns>
        public bool pruebaConectar()
        {

            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=perrera;Uid=kevin;password=1234");
                MySqlCommand comando = new MySqlCommand();

                comando.CommandText = "SELECT * FROM perro";
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }


        }



        //CONSULTAS


        public bool ejecutarComandoSinRetorno(string stringComando)
        {
            //Este metodo lo utilizare probablemente para saber sobre la existencia de algun valor en la base de datos.
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = stringComando; //toma el comando ingresado 
                comando.Connection = this.estableceConexion(); // se conecta al metodo encargado de realizar la coneccion
                Conexion.Open(); //abrimos la coneccion
                comando.ExecuteNonQuery(); //se ejecuta
                Conexion.Close();//Y cerramos coneccion
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool ExisteIdEnBaseDeDatos(MySqlCommand sqlCommand)
        {
            //para adaptar mas la funcionalidad
            DataSet DS = new DataSet();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();

            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando = sqlCommand;//tomamos el comando ingresado
                comando.Connection = estableceConexion();//coneccion establecida

                //adaptar el comando
                adaptador.SelectCommand = comando; //adaptamos el comando
                Conexion.Open();
                adaptador.Fill(DS); //rellenamos el adaptador con la informacion
                Conexion.Close();

                int count = Convert.ToInt32(adaptador);

                if(count == 0)
                {
                    return true;
                }
                return false;
               // return DS; //enviamos los datos
            }
            catch
            {
                return false;
            }

        }

        /************************************(    Retornando datos    )*************************************/
        public DataSet EjecutarSentencia(MySqlCommand sqlCommand)
        {
            //para adaptar mas la funcionalidad
            DataSet DS = new DataSet();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();

            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando = sqlCommand;//tomamos el comando ingresado
                comando.Connection = estableceConexion();//coneccion establecida

                //adaptar el comando
                adaptador.SelectCommand = comando; //adaptamos el comando
                Conexion.Open();
                adaptador.Fill(DS); //rellenamos el adaptador con la informacion
                Conexion.Close();

                return DS; //enviamos los datos
            }
            catch
            {
                return DS;
            }
            
        }


    }
}
