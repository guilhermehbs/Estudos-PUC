using Exercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
    static void Main(string[] args)
    {
        int opcao = 1;
        
        Biblioteca biblioteca = new Biblioteca();

        while (opcao != 0)
        {
            Console.WriteLine("Digite a opção desejada:");

            Console.WriteLine("--------------------");
            Console.WriteLine("        MENU        ");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Adicionar Livro");
            Console.WriteLine("2 - Remover Livro");
            Console.WriteLine("3 - Emprestar Livro");
            Console.WriteLine("4 - Devolver Livro");
            Console.WriteLine("5 - Cadastrar Cliente");
            Console.WriteLine("6 - Remover Cliente");
            Console.WriteLine("7 - Exibir lista de livros");
            Console.WriteLine("8 - Exibir lista de clientes");
            Console.WriteLine("0 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Opção selecionada: Adicionar Livro");

                    Livro livro = biblioteca.criarLivro();
                    biblioteca.adicionarLivro(livro);

                    break;

                case 2:

                    Console.WriteLine("Opção selecionada: Remover Livro");

                    Console.WriteLine("Digite o título do livro a ser removido: ");
                    string titulo = Console.ReadLine();

                    biblioteca.removerLivro(titulo);

                    break;
                case 3:
                    Console.WriteLine("Opção selecionada: Emprestar Livro");

                    Console.WriteLine("Digite o nome do cliente: ");
                    string nome = Console.ReadLine();

                    Cliente cliente = biblioteca.getClienteByName(nome);

                    Console.WriteLine("Digite o nome do livro que deseja pegar emprestado: ");
                    titulo = Console.ReadLine();

                    livro = biblioteca.getLivroByName(titulo);

                    cliente.emprestarLivro(livro);
                    biblioteca.atualizarStatusDeEmprestimo(livro);

                    break;
                case 4:
                    Console.WriteLine("Opção selecionada: Devolver Livro");

                    Console.WriteLine("Digite o nome do cliente: ");
                    nome = Console.ReadLine();

                    cliente = biblioteca.getClienteByName(nome);

                    Console.WriteLine("Digite o nome do livro que deseja devolver: ");
                    titulo = Console.ReadLine();

                    livro = biblioteca.getLivroByName(titulo);

                    cliente.devolverLivro(livro);
                    biblioteca.atualizarStatusDevolucao(livro);

                    break;
                case 5:
                    Console.WriteLine("Opção selecionada: Cadastrar Cliente");

                    Console.WriteLine("Digite o nome do cliente: ");
                    nome = Console.ReadLine();

                    cliente = new Cliente(nome);
                    biblioteca.adicionarClientes(cliente);

                    break;
                case 6:
                    Console.WriteLine("Opção selecionada: Remover Cliente");

                    Console.WriteLine("Digite o id do cliente a ser removido: ");
                    int id = int.Parse(Console.ReadLine());

                    biblioteca.removerClientes(id);

                    break;
                case 7:
                    Console.WriteLine("Opção selecionada: Exibir lista de livros");

                    biblioteca.exibirListaDeLivros();

                    break;
                case 8:
                    Console.WriteLine("Opção selecionada: Exibir lista de clientes");

                    biblioteca.exibirListaDeClientes();

                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

    }
}