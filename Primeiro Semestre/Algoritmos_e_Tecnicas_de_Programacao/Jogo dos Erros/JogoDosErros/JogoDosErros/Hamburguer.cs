using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDosErros
{
    class Hamburguer
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public Hamburguer(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void ImprimirDetalhes()
        {
            Console.WriteLine("Hambúrguer: " + Nome);
            Console.WriteLine("Preço: R$" + Preco);
        }
    }
}
