using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.InserirFim(5);
            lista.InserirFim(7);
            lista.InserirFim(8);

            int tamanho = lista.tamanhoLista();

            Console.WriteLine(tamanho);
        }
    }
}
