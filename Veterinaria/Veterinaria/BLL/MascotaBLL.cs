using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{

    class MascotaBLL
    {

        private int num_cliente;
        private string nombre;
        private string raza;
        private string color;
        private string alergico;
        private string atencion_especial;
        private string observaciones;
      

        private DuenioBLL unDuenio;

        public MascotaBLL()
        {
        }

        public MascotaBLL(int num_cliente, string nombre, string raza, string color, string alergico, string atencion_especial, string observaciones, DuenioBLL unDuenio)
        {
            this.Num_cliente = num_cliente;
            this.Nombre = nombre;
            this.Raza = raza;
            this.Color = color;
            this.Alergico = alergico;
            this.Atencion_especial = atencion_especial;
            this.Observaciones = observaciones;
            this.UnDuenio = unDuenio;
        }

        public string Atencion_especial { get => atencion_especial; set => atencion_especial = value; }
        public int Num_cliente { get => num_cliente; set => num_cliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Color { get => color; set => color = value; }
        public string Alergico { get => alergico; set => alergico = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        internal DuenioBLL UnDuenio { get => unDuenio; set => unDuenio = value; }
    }
}
