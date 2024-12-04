using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedList<string, List<string>> dicionarioSinonimos = new SortedList<string, List<string>>();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("a) Adicionar uma nova palavra e seus sinônimos");
            Console.WriteLine("b) Pesquisar os sinônimos de uma palavra em específico");
            Console.WriteLine("c) Exibir o dicionário em ordem alfabética das palavras");
            Console.WriteLine("s) Sair");

            char escolha = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Adicione uma linha em branco para melhorar a legibilidade.

            switch (escolha)
            {
                case 'a':
                    Console.Write("Digite uma palavra: ");
                    string palavra = Console.ReadLine().ToLower();
                    Console.Write("Digite os sinônimos (separados por espaço): ");
                    string sinonimosInput = Console.ReadLine().ToLower();
                    string[] sinonimosArray = sinonimosInput.Split(' ');
                    List<string> sinonimos = new List<string>(sinonimosArray);

                    if (dicionarioSinonimos.ContainsKey(palavra))
                    {
                        dicionarioSinonimos[palavra].AddRange(sinonimos);
                    }
                    else
                    {
                        dicionarioSinonimos[palavra] = sinonimos;
                    }

                    Console.WriteLine($"A palavra '{palavra}' e seus sinônimos foram adicionados ao dicionário.");
                    break;

                case 'b':
                    Console.Write("Digite a palavra cujos sinônimos você deseja pesquisar: ");
                    string palavraPesquisar = Console.ReadLine().ToLower();
                    if (dicionarioSinonimos.ContainsKey(palavraPesquisar))
                    {
                        Console.WriteLine($"Sinônimos para '{palavraPesquisar}':");
                        foreach (var sinonimo in dicionarioSinonimos[palavraPesquisar])
                        {
                            Console.WriteLine(sinonimo);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"A palavra '{palavraPesquisar}' não foi encontrada no dicionário.");
                    }
                    break;

                case 'c':
                    Console.WriteLine("Dicionário em ordem alfabética das palavras:");
                    foreach (var entrada in dicionarioSinonimos)
                    {
                        Console.WriteLine($"{entrada.Key}: {string.Join(", ", entrada.Value)}");
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
}
