using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDupla lista = new ListaDupla();

            lista.InserirFim(1);
            lista.InserirFim(2);
            lista.InserirFim(3);
            lista.InserirFim(4);
            lista.InserirFim(5);

            lista.Mostrar();

            lista.Inverter();

            lista.Mostrar();

        }
    }
}
