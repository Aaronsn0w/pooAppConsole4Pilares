using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAppConsole
{
    class Emilio : Estudiante // Clase Emilio Hereda Atributos y Metodos de la clase padre Estudiante, Este es el Pilar de la Herencia
    {
        private string nombreCompleto { get; }
        public Emilio(string nombre, string apellido, string matricula, string sector)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.matricula = matricula;
            this.sector = sector;
            this.nombreCompleto = this.nombre + " " + this.apellido;
        }

        public Array mostrarDatos()
        {
            string[] info = new string[3] { "Nombre y Apellido: "+this.nombreCompleto, "Matricula: "+this.matricula, "Sector: "+this.sector};
            return info;
        }
    }
}
