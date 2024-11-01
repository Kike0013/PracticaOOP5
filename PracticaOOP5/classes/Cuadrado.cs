using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP5.classes
{
    internal class Cuadrado : FiguraGeometrica
    {
        public void TransformarALado(double lado)
        {
            baseFigura = lado;
            alturaFigura = lado;
        }

        public override double CalcularArea()
        {
            return baseFigura * alturaFigura;
        }
    }
}
