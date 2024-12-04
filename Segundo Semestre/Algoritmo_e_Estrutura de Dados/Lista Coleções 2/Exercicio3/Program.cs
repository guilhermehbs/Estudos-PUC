using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        SortedList<int, string> rankingJogadores = new SortedList<int, string>();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("d) Adicionar um novo jogador e sua pontuação");
            Console.WriteLine("e) Verificar a pontuação de um jogador em específico");
            Console.WriteLine("f) Remover um jogador, bem como sua pontuação");
            Console.WriteLine("g) Exibir o ranking de pontuação de forma crescente");
            Console.WriteLine("s) Sair");

            char escolha = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Adicione uma linha em branco para melhorar a legibilidade.

            switch (escolha)
            {
                case 'd':
                    Console.Write("Digite o nome do jogador: ");
                    string nomeJogador = Console.ReadLine();
                    Console.Write("Digite a pontuação do jogador: ");
                    int pontuacaoJogador = int.Parse(Console.ReadLine());
                    rankingJogadores[pontuacaoJogador] = nomeJogador;
                    Console.WriteLine($"O jogador '{nomeJogador}' com pontuação {pontuacaoJogador} foi adicionado ao ranking.");
                    break;

                case 'e':
                    Console.Write("Digite o nome do jogador cuja pontuação você deseja verificar: ");
                    string jogadorVerificar = Console.ReadLine();
                    int pontuacao = BuscarPontuacaoJogador(rankingJogadores, jogadorVerificar);
                    if (pontuacao != -1)
                    {
                        Console.WriteLine($"A pontuação do jogador '{jogadorVerificar}' é {pontuacao}");
                    }
                    else
                    {
                        Console.WriteLine($"O jogador '{jogadorVerificar}' não foi encontrado no ranking.");
                    }
                    break;

                case 'f':
                    Console.Write("Digite o nome do jogador que você deseja remover: ");
                    string jogadorRemover = Console.ReadLine();
                    if (rankingJogadores.ContainsValue(jogadorRemover))
                    {
                        int pontuacaoRemover = BuscarPontuacaoJogador(rankingJogadores, jogadorRemover);
                        rankingJogadores.Remove(pontuacaoRemover);
                        Console.WriteLine($"O jogador '{jogadorRemover}' com pontuação {pontuacaoRemover} foi removido do ranking.");
                    }
                    else
                    {
                        Console.WriteLine($"O jogador '{jogadorRemover}' não foi encontrado no ranking.");
                    }
                    break;

                case 'g':
                    Console.WriteLine("Ranking de pontuação de forma crescente:");
                    foreach (var jogador in rankingJogadores)
                    {
                        Console.WriteLine($"{jogador.Value}: {jogador.Key} pontos");
                    }
                    break;

                case 's':
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static int BuscarPontuacaoJogador(SortedList<int, string> ranking, string nomeJogador)
    {
        foreach (var jogador in ranking)
        {
            if (jogador.Value == nomeJogador)
            {
                return jogador.Key;
            }
        }
        return -1;
    }
}
