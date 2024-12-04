using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.InserirFim(1);
            lista.InserirFim(2);
            lista.InserirFim(4);
            lista.InserirFim(5);

            lista.Mostrar();

            lista.InserirOrdenado(3);

            lista.Mostrar();
        }
    }
}
