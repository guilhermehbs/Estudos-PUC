using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_06_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();

            circulo.calcularArea(5);
            Console.WriteLine("A área é: " + circulo.calcularArea);
        }
    }
}