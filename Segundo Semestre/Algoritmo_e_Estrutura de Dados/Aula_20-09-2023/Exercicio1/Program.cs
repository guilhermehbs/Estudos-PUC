using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static List<string> list = new List<string>();

        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 9)
            {

                Console.WriteLine("-------------------------------");
                Console.WriteLine("             MENU               ");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1 - Adicionar filme");
                Console.WriteLine("2 - Adicionar filme na posição");
                Console.WriteLine("3 - Remover filme");
                Console.WriteLine("4 - Remover filme na posição");
                Console.WriteLine("5 - Procurar filme");
                Console.WriteLine("6 - Imprimir lista");
                Console.WriteLine("7 - Inverter lista");
                Console.WriteLine("8 - Ordenar lista");
                Console.WriteLine("9 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Digite o nome do filme: ");
                        string nome = Console.ReadLine();

                        adicionarFilme(nome);
                        break;

                    case 2:
                        Console.WriteLine("Digite a posição que deseja innserir o filme: ");
                        int posicao = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o nome do filme a ser inserido: ");
                        nome = Console.ReadLine();

                        inserirFilmePosicao(posicao, nome);
                        break;

                    case 3:
                        Console.WriteLine("Digite o nome do filme para ser removido");
                        nome = Console.ReadLine();

                        removerFilme(nome);
                        break;
                    
                    case 4:
                        Console.WriteLine("Digite a posição do filme que deseja remover: ");
                        posicao = int.Parse(Console.ReadLine());

                        removerFilmePosicao(posicao);

                        break;

                    case 5:
                        Console.WriteLine("Digite o nome do filme que deseja procurar: ");
                        nome = Console.ReadLine();

                        procurarFilme(nome);

                        break;

                    case 6:
                        imprimirLista();
                        break;

                    case 7:
                        inverterLista();
                        imprimirLista();
                        break;

                    case 8:
                        ordenarLista();
                        imprimirLista();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida");
                        Console.ResetColor();
                        break;
                }
            }
        }

        static bool adicionarFilme(string nome)
        {
            list.Add(nome);
            return true;
        }

        static void inserirFilmePosicao(int posicao, string nome)
        {
            if (posicao > list.Count)
            {
                Console.WriteLine($"A posição não existe, a lista tem {list.Count} posições");
            }
            else
            {
                list.Insert(posicao, nome);
            }
        }

        static void removerFilme(string nome)
        {
            if (list.Contains(nome))
            {
                list.Remove(nome);
                Console.WriteLine("Removido");
            }
            else
            {
                Console.WriteLine("Livro não está na lista de filmes");
            }
        }

        static void removerFilmePosicao(int posicao)
        {
            if (posicao <= list.Count)
            {
                list.RemoveAt(posicao);
                Console.WriteLine("Removido");
            }
            else
            {
                Console.WriteLine("A posição não existe");
            }
        }

        static bool procurarFilme(string nome)
        {
            if (list.Contains(nome))
            {
                return true;
            } else 
            { 
                return false; 
            }
        }

        static void imprimirLista()
        {
            foreach (string filme in list)
            {
                Console.WriteLine(filme);
            }
        }

        static void inverterLista()
        {
            list.Reverse();
        }

        static void ordenarLista()
        {
            list.Sort();
        }
    }
}
