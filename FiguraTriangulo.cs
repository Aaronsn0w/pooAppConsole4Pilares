using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAppConsole
{
    class FiguraTriangulo : FiguraRectangulo
    {
        public int Area(int Base, int Altura)
        {
            return (Base * Altura) / 2;
        }
    }
}
