using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Biblioteca
    {
        private List<Livro> listaDeLivros;
        private List<Cliente> listaDeClientes;

        public Biblioteca()
        {
            listaDeLivros = new List<Livro>();
            listaDeClientes = new List<Cliente>();
        }

        public Livro criarLivro()
        {

            Console.WriteLine("Digite o título do Livro: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o autor do Livro: ");
            string autor = Console.ReadLine();

            Console.WriteLine("Digite o ano de publicação do livro: ");
            int anoPublicacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de páginas do livro: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, anoPublicacao, paginas);

            return livro;
        }

        public void adicionarLivro(Livro livro)
        {
            listaDeLivros.Add(livro);
            Console.WriteLine($"Livro: {livro} foi adicionado a lista de livros");
        }

        public void removerLivro(string titulo)
        {
            //List<Livro> handleLivros = new List<Livro>();
            //listaDeLivros.CopyTo(handleLivros, 0, listaDeLivros.Count);
            foreach (var livro in listaDeLivros)
            {
                if (livro.getTitulo() == titulo)
                {
                    listaDeLivros.Remove(livro);
                    Console.WriteLine($"Livro: {livro} foi removido da lista de livros");
                    break;
                }
            }
        }

        public void adicionarClientes(Cliente cliente)
        {
            listaDeClientes.Add(cliente);
            Console.WriteLine($"Cliente: {cliente} foi adicionado a lista de clientes");
        }

        public void removerClientes(int id)
        {
            foreach (var cliente in listaDeClientes)
            {
                if (cliente.getId() == id)
                {
                    listaDeClientes.Remove(cliente);
                    Console.WriteLine($"Cliente: {cliente} foi removido da lista de clientes");
                    break;
                }
            }
        }

        public void exibirListaDeLivros()
        {
            Console.WriteLine("Lista de livros: ");

            foreach (var livro in listaDeLivros)
            {
                Console.WriteLine(livro.ToString());
            }
        }

        public void exibirListaDeClientes()
        {
            Console.WriteLine("Lista de clientes: ");

            foreach (var cliente in listaDeClientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }

        public void atualizarStatusDeEmprestimo(Livro livro)
        {
            if (livro.getStatus() == "Disponível")
            {
                livro.setStatus("Emprestado");
            }
        }

        public void atualizarStatusDevolucao(Livro livro)
        {
            if (livro.getStatus() == "Emprestado")
            {
                livro.setStatus("Disponível");
            }
        }

        public Livro getLivroByName(string name)
        { 
            int index = listaDeLivros.FindIndex(livro => livro.getTitulo() == name);
            return listaDeLivros[index];
        }

        public Cliente getClienteByName(string name)
        {
            int index = listaDeClientes.FindIndex(livro => livro.getNome() == name);
            return listaDeClientes[index];
        }
    }
}
