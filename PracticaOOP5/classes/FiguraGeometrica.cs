using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP5.classes
{
    public abstract class FiguraGeometrica
    {
        public double baseFigura;
        public double alturaFigura;

        public abstract double CalcularArea();
    }
}
