using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Veterinaria.BDD
{

    class MascotaBDD
    {
        ConexionBDD conexion = new ConexionBDD();
    
        /// <summary>
        /// CREA LA CONECCION
        /// </summary>
        public MascotaBDD()
        {
            conexion = new ConexionBDD();
        }

        public bool Agregar(MascotaBLL oMascotaBLL)
        {            return conexion.ejecutarComandoSinRetorno($"INSERT INTO mascota(nombre,raza,color,alergico,atencion_especial,observaciones,dni_duenio)" +
                 $"VALUES('" + oMascotaBLL.Nombre + "','" + oMascotaBLL.Raza + "','" + oMascotaBLL.Color + "','" + oMascotaBLL.Alergico + "','" +
                 oMascotaBLL.Atencion_especial + "','" + oMascotaBLL.Observaciones + "','" + oMascotaBLL.UnDuenio.Dni + "')");
         }


        public DataSet MostrarMascotas()
        {
            MySqlCommand sentencia = new MySqlCommand("SELECT * FROM mascota");
            return conexion.EjecutarSentencia(sentencia);
        }

        public int Eliminar(int id)
        {

            conexion.ejecutarComandoSinRetorno($"DELETE FROM mascota WHERE id_mascota=" + id);
            return 1;
        }

    }
        }
