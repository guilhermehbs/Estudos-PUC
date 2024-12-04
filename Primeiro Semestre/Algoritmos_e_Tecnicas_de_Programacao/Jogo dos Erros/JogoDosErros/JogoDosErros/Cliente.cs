using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDosErros
{
    class Cliente
    {
        private string Nome { get; set; }
        private string Endereco { get; set; }

        public Cliente(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public void ImprimirDetalhes()
        {
            Console.WriteLine("Cliente: " + Nome);
            Console.WriteLine("Endereço: " + Endereco);
        }
    }
}
