using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Agenda
    {
        private ListaDupla listaContatos = new ListaDupla();

        public void AdicionarContato(string nome, string telefone, string email)
        {
            Contato novoContato = new Contato(nome, telefone, email);
            listaContatos.InserirFim(novoContato);
        }

        public void AtualizarContato(int posicao, string nome, string telefone, string email)
        {
            if (posicao >= 0 && posicao < listaContatos.Tamanho())
            {
                Contato contatoAtualizado = new Contato(nome, telefone, email);
                listaContatos.AlterarElemento(posicao, contatoAtualizado);
            }
            else
            {
                Console.WriteLine("Posição inválida.");
            }
        }

        public void ExcluirContato(int posicao)
        {
            if (posicao >= 0 && posicao < listaContatos.Tamanho())
            {
                listaContatos.Remover(posicao);
            }
            else
            {
                Console.WriteLine("Posição inválida.");
            }
        }

        public void ListarContatos()
        {
            Console.WriteLine("Lista de Contatos:");
            for (int i = 0; i < listaContatos.Tamanho(); i++)
            {
                Contato contato = listaContatos.Recuperar(i);
                Console.WriteLine($"Posição {i+1}: {contato}");
            }
        }
    }
}
