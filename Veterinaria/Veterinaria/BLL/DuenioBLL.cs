using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Veterinaria
{
    class DuenioBLL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Esta anotación indica que la propiedad será autoincremental
         private string dni { get; set; }


        private string nombre { get; set; }
        private string celDuenio { get; set; }


        public DuenioBLL()
        {
        }

        public DuenioBLL(string dni_duenio, string nombre, string celDuenio)
        {

            this.dni = dni_duenio;
            this.nombre = nombre;
            this.celDuenio = celDuenio;
            
        }


      public string Dni { get => dni; set => dni = value; }
      public string Nombre { get => nombre; set => nombre = value; }
      public string CelDuenio { get => celDuenio; set => celDuenio = value; }
    }
}
