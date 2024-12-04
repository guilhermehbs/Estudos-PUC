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
            ArvoreBinaria arvore = new ArvoreBinaria();

            arvore.Inserir(1);
            arvore.Inserir(2);
            arvore.Inserir(3);
            arvore.Inserir(4);
            arvore.Inserir(10);

            Console.WriteLine("Soma: " + arvore.somaArvore());
        }
    }
}
