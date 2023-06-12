using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosRadianes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradosAr, radianes;
            Console.Write("Ingresa los grados:   ");
            gradosAr= Convert.ToDouble(Console.ReadLine());

            //Invocamos al metodo
            radianes = GradosRadianes(gradosAr);

            //Mostramos el resultado, con el valor del metodo
            Console.WriteLine("{0}° =   {1} radianes  ", gradosAr, radianes);
        }

        static double GradosRadianes(double gradosPa)
        {
            double radianes;
            //const double pi = 3.14159265359;
            //podemos usar varias opciones para declarar PI
            //radianes = (gradosPa * pi) / 180;
            radianes = (gradosPa * Math.PI) / 180;
            return radianes;
        }
    }
}
