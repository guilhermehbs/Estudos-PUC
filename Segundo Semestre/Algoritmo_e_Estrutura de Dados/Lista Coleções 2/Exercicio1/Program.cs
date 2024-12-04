using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        string filePath = "Aula_Praticas_Collections.txt";

        try
        {
            string[] linhas = File.ReadAllLines(filePath);

            foreach (string linha in linhas)
            {
                string[] words = linha.Split(' ', '.', ',', ';', '!', '?', ':');

                foreach (string word in words)
                {
                    string cleanedWord = word.ToLower().Trim();
                    if (!string.IsNullOrWhiteSpace(cleanedWord))
                    {
                        if (wordCount.ContainsKey(cleanedWord))
                        {
                            wordCount[cleanedWord]++;
                        }
                        else
                        {
                            wordCount[cleanedWord] = 1;
                        }
                    }
                }
            }

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Verificar se uma palavra está no dicionário");
                Console.WriteLine("2. Consultar quantas palavras distintas estão no dicionário");
                Console.WriteLine("3. Imprimir todas as palavras e suas frequências");
                Console.WriteLine("4. Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a palavra que deseja verificar: ");
                        string palavra = Console.ReadLine().ToLower();
                        if (wordCount.ContainsKey(palavra))
                        {
                            Console.WriteLine($"A palavra '{palavra}' aparece {wordCount[palavra]} vezes.");
                        }
                        else
                        {
                            Console.WriteLine("A palavra não está no dicionário.");
                        }
                        break;

                    case 2:
                        Console.WriteLine($"Existem {wordCount.Count} palavras distintas no dicionário.");
                        break;

                    case 3:
                        Console.WriteLine("Palavras e suas frequências:");
                        foreach (var word in wordCount)
                        {
                            Console.WriteLine($"{word.Key}: {word.Value} vezes");
                        }
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {e.Message}");
        }
    }
}
