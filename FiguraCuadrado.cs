using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAppConsole
{
    class FiguraCuadrado: FiguraRectangulo
    {
        public int Area(int Lado)
        {
            return Lado * Lado;
        }
    }
}
