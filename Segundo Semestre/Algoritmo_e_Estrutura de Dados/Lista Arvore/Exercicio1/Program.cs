using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinaria arvore = new ArvoreBinaria();

            arvore.Inserir(7);
            arvore.Inserir(1);
            arvore.Inserir(3);


            Console.WriteLine(arvore.EncontrarFolhas());
        }
    }
}
