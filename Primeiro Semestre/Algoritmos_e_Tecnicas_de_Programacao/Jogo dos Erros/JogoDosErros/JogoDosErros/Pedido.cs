using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDosErros
{
    class Pedido
    {
        private Cliente Cliente { get; }
        private Hamburguer Hamburguer { get; }

        public Pedido(Cliente cliente, Hamburguer hamburguer)
        {
            Cliente = cliente;
            Hamburguer = hamburguer;
        }

        public void ImprimirDetalhes()
        {
            Console.WriteLine("--- Detalhes do Pedido ---");
            Cliente.ImprimirDetalhes();
            Hamburguer.ImprimirDetalhes();
            Console.WriteLine("--------------------------");
        }
    }
}
