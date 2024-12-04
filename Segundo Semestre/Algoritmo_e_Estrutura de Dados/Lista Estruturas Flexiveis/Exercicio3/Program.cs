using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
            static void Main(string[] args)
            {
                ListaDupla listaDupla = new ListaDupla();

                listaDupla.InserirInicio(5);
                listaDupla.InserirInicio(3);
                listaDupla.InserirInicio(7);
                listaDupla.InserirInicio(2);

                int valor, posicao;

                bool encontrouSimples = listaDupla.encontrarMaior(out valor, out posicao);

                if (encontrouSimples)
                {
                    Console.WriteLine("Maior elemento na lista simples:");
                    Console.WriteLine("Posição: " + posicao);
                    Console.WriteLine("Valor: " + valor);
                }
                else
                {
                    Console.WriteLine("Lista simples vazia.");
                }
            }
    }
}
