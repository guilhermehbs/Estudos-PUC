using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.InserirFim(1);
            lista.InserirFim(2);
            lista.InserirFim(3);
            lista.InserirFim(4);

            Lista segundaLista = new Lista();

            segundaLista.InserirFim(5);
            segundaLista.InserirFim(6);
            segundaLista.InserirFim(7);
            segundaLista.InserirFim(8);

            lista.Mostrar();

            lista.UnirListas(segundaLista);

            lista.Mostrar();
        }
    }
}