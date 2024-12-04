using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        Dictionary<int, int> frequenciaNumeros = new Dictionary<int, int>();

        Console.WriteLine("Digite uma lista de números inteiros separados por espaço (ex: 1 2 3 4):");
        string entrada = Console.ReadLine();
        string[] numerosString = entrada.Split(' ');

        foreach (string numeroString in numerosString)
        {
            if (int.TryParse(numeroString, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine($"Ignorando entrada inválida: {numeroString}");
            }
        }

        foreach (int numero in numeros)
        {
            if (frequenciaNumeros.ContainsKey(numero))
            {
                frequenciaNumeros[numero]++;
            }
            else
            {
                frequenciaNumeros[numero] = 1;
            }
        }

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Verificar se um número está no dicionário");
            Console.WriteLine("2. Consultar quantos números distintos estão no dicionário");
            Console.WriteLine("3. Imprimir todos os números e suas frequências");
            Console.WriteLine("4. Sair");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Write("Digite o número que deseja verificar: ");
                    int numeroVerificar = int.Parse(Console.ReadLine());
                    if (frequenciaNumeros.ContainsKey(numeroVerificar))
                    {
                        Console.WriteLine($"O número {numeroVerificar} aparece {frequenciaNumeros[numeroVerificar]} vezes.");
                    }
                    else
                    {
                        Console.WriteLine($"O número {numeroVerificar} não está no dicionário.");
                    }
                    break;

                case 2:
                    Console.WriteLine($"Existem {frequenciaNumeros.Count} números distintos no dicionário.");
                    break;

                case 3:
                    Console.WriteLine("Números e suas frequências:");
                    foreach (var numero in frequenciaNumeros)
                    {
                        Console.WriteLine($"{numero.Key}: {numero.Value} vezes");
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
}
