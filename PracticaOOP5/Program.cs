using PracticaOOP5.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En esta versión, se viola el principio LSP:");

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.baseFigura = 5;
            rectangulo.alturaFigura = 10;
            Console.WriteLine("Área de rectángulo: " + rectangulo.CalcularArea());

            Cuadrado cuadrado = new Cuadrado();
            cuadrado.TransformarALado(5);
            cuadrado.baseFigura = 5;
            cuadrado.alturaFigura = 10;

            Console.WriteLine("Área esperada de cuadrado: 25");
            Console.WriteLine("Área calculada: " + cuadrado.CalcularArea());

            /*
             * 
             * Solución:
             * 
             */

            Console.WriteLine("\nAquí se arregla para cumplir con LSP:");

            Rectangulo rectanguloLSP = new Rectangulo();
            rectanguloLSP.baseFigura = 5;
            rectanguloLSP.alturaFigura = 10;
            Console.WriteLine("Área de rectángulo: " + rectanguloLSP.CalcularArea());

            Cuadrado cuadradoLSP = new Cuadrado();
            cuadradoLSP.TransformarALado(5);
            Console.WriteLine("Área de cuadrado: " + cuadradoLSP.CalcularArea());

            Console.ReadKey();
        }
    }
}
