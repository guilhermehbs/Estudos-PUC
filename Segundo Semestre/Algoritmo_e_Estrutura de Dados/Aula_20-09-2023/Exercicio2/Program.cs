using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Inserir número na lista");
            Console.WriteLine("2 - Verificar se um número está na lista");
            Console.WriteLine("3 - Exibir a soma de todos os números na lista");
            Console.WriteLine("4 - Exibir o maior número na lista");
            Console.WriteLine("5 - Exibir o menor número na lista");
            Console.WriteLine("6 - Remover todos os números pares da lista");
            Console.WriteLine("7 - Exibir os números na lista após a remoção dos pares");
            Console.WriteLine("8 - Inverter os elementos da lista");
            Console.WriteLine("9 - Encerrar o programa");

            int escolha;
            if (int.TryParse(Console.ReadLine(), out escolha))
            {
                switch (escolha)
                {
                    case 1:
                        Console.Write("Digite o número a ser inserido: ");
                        int numero = int.Parse(Console.ReadLine());
                        numeros.Add(numero);
                        break;
                    case 2:
                        Console.Write("Digite o número a ser verificado: ");
                        int numeroVerificar = int.Parse(Console.ReadLine());
                        bool existe = numeros.Contains(numeroVerificar);
                        Console.WriteLine($"O número {numeroVerificar} " + (existe ? "está" : "não está") + " na lista.");
                        break;
                    case 3:
                        int soma = numeros.Sum();
                        Console.WriteLine($"A soma de todos os números na lista é: {soma}");
                        break;
                    case 4:
                        int maior = numeros.Max();
                        Console.WriteLine($"O maior número na lista é: {maior}");
                        break;
                    case 5:
                        int menor = numeros.Min();
                        Console.WriteLine($"O menor número na lista é: {menor}");
                        break;
                    case 6:
                        numeros.RemoveAll(n => n % 2 == 0);
                        Console.WriteLine("Números pares removidos da lista.");
                        break;
                    case 7:
                        Console.WriteLine("Números na lista após a remoção dos pares:");
                        foreach (int num in numeros)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 8:
                        numeros.Reverse();
                        Console.WriteLine("Elementos da lista foram invertidos.");
                        break;
                    case 9:
                        Console.WriteLine("Programa encerrado.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}
