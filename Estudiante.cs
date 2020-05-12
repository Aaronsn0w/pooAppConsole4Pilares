using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAppConsole
{
    class Estudiante // definiendo clase con sus atributos, la misma es abstracta y Principal o Padre
    {
        protected string nombre { get; set; }
        protected string apellido { get; set; }
        protected string matricula { get; set; }
        protected string sector { get; set; }
    }
}
