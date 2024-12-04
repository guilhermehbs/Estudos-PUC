using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_06_2023
{
    internal class Circulo
    {
        private double raio;
        private double area;

        public double calcularArea(double raio)
        {
            this.raio = raio;

            area = 3.14 * Math.Pow(raio, 2);

            return area;

        }
    }
}
