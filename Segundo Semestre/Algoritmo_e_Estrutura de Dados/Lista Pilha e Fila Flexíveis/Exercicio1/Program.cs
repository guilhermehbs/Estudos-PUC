using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static Pilha pilha = new Pilha();
        static void Main() {
           

            pilha.Inserir(2);
            pilha.Inserir(3);
            pilha.Inserir(4);

            //pilha.Mostrar();

            pilha.inverter();

            pilha.Mostrar();

        }

    }
}
