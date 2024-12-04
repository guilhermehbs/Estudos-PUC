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

            arvore.Inserir(7);
            arvore.Inserir(6);
            arvore.Inserir(8);
            arvore.Inserir(9);
            arvore.Inserir(10);
            arvore.Inserir(11);


            Console.WriteLine(arvore.EhAVL());
        }
    }
}
