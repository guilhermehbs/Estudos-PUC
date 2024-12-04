using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> listaFilmes = new LinkedList<string>();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Inserir um filme no final da lista");
            Console.WriteLine("2 - Inserir um filme depois de uma posição específica da lista");
            Console.WriteLine("3 - Inserir um filme antes de uma posição específica da lista");
            Console.WriteLine("4 - Remover o filme que estiver no final da lista");
            Console.WriteLine("5 - Pesquisar se um filme consta na lista");
            Console.WriteLine("6 - Listar todos os filmes da lista");
            Console.WriteLine("7 - Encerrar o programa");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Write("Digite o nome do filme a ser inserido no final da lista: ");
                    string filmeFinal = Console.ReadLine();
                    listaFilmes.AddLast(filmeFinal);
                    Console.WriteLine($"O filme '{filmeFinal}' foi adicionado ao final da lista.");
                    break;

                case 2:
                    Console.Write("Digite o nome do filme a ser inserido: ");
                    string filmeInserir = Console.ReadLine();
                    Console.Write("Digite o nome do filme após o qual deseja inserir: ");
                    string filmeApos = Console.ReadLine();
                    LinkedListNode<string> nodeApos = listaFilmes.Find(filmeApos);
                    if (nodeApos != null)
                    {
                        listaFilmes.AddAfter(nodeApos, filmeInserir);
                        Console.WriteLine($"O filme '{filmeInserir}' foi inserido depois de '{filmeApos}'.");
                    }
                    else
                    {
                        Console.WriteLine($"O filme '{filmeApos}' não foi encontrado na lista.");
                    }
                    break;

                case 3:
                    Console.Write("Digite o nome do filme a ser inserido: ");
                    string filmeInserirAntes = Console.ReadLine();
                    Console.Write("Digite o nome do filme antes do qual deseja inserir: ");
                    string filmeAntes = Console.ReadLine();
                    LinkedListNode<string> nodeAntes = listaFilmes.Find(filmeAntes);
                    if (nodeAntes != null)
                    {
                        listaFilmes.AddBefore(nodeAntes, filmeInserirAntes);
                        Console.WriteLine($"O filme '{filmeInserirAntes}' foi inserido antes de '{filmeAntes}'.");
                    }
                    else
                    {
                        Console.WriteLine($"O filme '{filmeAntes}' não foi encontrado na lista.");
                    }
                    break;

                case 4:
                    if (listaFilmes.Count > 0)
                    {
                        string filmeRemovido = listaFilmes.Last.Value;
                        listaFilmes.RemoveLast();
                        Console.WriteLine($"O filme '{filmeRemovido}' foi removido do final da lista.");
                    }
                    else
                    {
                        Console.WriteLine("A lista de filmes está vazia. Não é possível remover.");
                    }
                    break;

                case 5:
                    Console.Write("Digite o nome do filme a ser pesquisado: ");
                    string filmePesquisar = Console.ReadLine();
                    if (listaFilmes.Contains(filmePesquisar))
                    {
                        Console.WriteLine($"O filme '{filmePesquisar}' consta na lista.");
                    }
                    else
                    {
                        Console.WriteLine($"O filme '{filmePesquisar}' não consta na lista.");
                    }
                    break;

                case 6:
                    Console.WriteLine("Lista de filmes:");
                    foreach (string filme in listaFilmes)
                    {
                        Console.WriteLine(filme);
                    }
                    break;

                case 7:
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
