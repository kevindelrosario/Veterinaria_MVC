using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.BDD
{
    class DuenioBDD
    {
        ConexionBDD conexion = new ConexionBDD();

        public DuenioBDD()
        {
            conexion = new ConexionBDD();
        }

        public bool Agregar(DuenioBLL oDuenioBLL)
        {

            return conexion.ejecutarComandoSinRetorno($"INSERT INTO duenio(dni,nombre,cel_duenio)" +
               $"VALUES('" + oDuenioBLL.Dni + "','"+ oDuenioBLL.Nombre + "','" + oDuenioBLL.CelDuenio + "')");

        }

        

        public bool existe(DuenioBLL oDuenioBLL)
        {
            MySqlCommand sentencia = new MySqlCommand("select count(dni) from duenio where dni ='" + oDuenioBLL.Dni + "';");
            return(conexion.ExisteIdEnBaseDeDatos(sentencia));
        }

        public DataSet MostrarDuenios()
        {
            MySqlCommand sentencia = new MySqlCommand("SELECT * FROM duenio");
            return conexion.EjecutarSentencia(sentencia);
        }

        public DataSet BuscarDuenios(string dni)
        {
            MySqlCommand sentencia = new MySqlCommand("SELECT * FROM duenio where dni ='"+ dni+"'" );
            return conexion.EjecutarSentencia(sentencia);
        }
        public string BuscarDueniosString(string dni)
        {
            MySqlCommand sentencia = new MySqlCommand("SELECT * FROM duenio where dni ='" + dni + "'");
            return Convert.ToString(conexion.EjecutarSentencia(sentencia));
        }
    }
}
