using System;
using System.Collections.Generic;

class Program
{
    static Queue<int> filaIniciacaoCientifica = new Queue<int>();
    static Queue<int> filaMestrado = new Queue<int>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Inserir um aluno na fila de espera de bolsas de Iniciação Científica");
            Console.WriteLine("2 - Inserir um aluno na fila de espera de bolsas de Mestrado");
            Console.WriteLine("3 - Remover um aluno da fila de bolsas de Iniciação Científica");
            Console.WriteLine("4 - Remover um aluno da fila de bolsas de Mestrado");
            Console.WriteLine("5 - Mostrar fila de espera de bolsas de Iniciação Científica");
            Console.WriteLine("6 - Mostrar fila de espera de bolsas de Mestrado");
            Console.WriteLine("7 - Pesquisar aluno na fila de espera de bolsas de Iniciação Científica");
            Console.WriteLine("8 - Pesquisar aluno na fila de espera de bolsas de Mestrado");
            Console.WriteLine("9 - Mostrar qual o aluno que está no início da fila de espera de bolsas de Iniciação Científica");
            Console.WriteLine("10 - Mostrar qual o aluno que está no início da fila de espera de bolsas de Mestrado");
            Console.WriteLine("11 - Encerrar o programa");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    InserirAluno(filaIniciacaoCientifica, "Iniciação Científica");
                    break;
                case 2:
                    InserirAluno(filaMestrado, "Mestrado");
                    break;
                case 3:
                    RemoverAluno(filaIniciacaoCientifica, "Iniciação Científica");
                    break;
                case 4:
                    RemoverAluno(filaMestrado, "Mestrado");
                    break;
                case 5:
                    MostrarFila(filaIniciacaoCientifica, "Fila de Iniciação Científica");
                    break;
                case 6:
                    MostrarFila(filaMestrado, "Fila de Mestrado");
                    break;
                case 7:
                    PesquisarAluno(filaIniciacaoCientifica, "Iniciação Científica");
                    break;
                case 8:
                    PesquisarAluno(filaMestrado, "Mestrado");
                    break;
                case 9:
                    MostrarPrimeiroAluno(filaIniciacaoCientifica, "Iniciação Científica");
                    break;
                case 10:
                    MostrarPrimeiroAluno(filaMestrado, "Mestrado");
                    break;
                case 11:
                    Console.WriteLine("Encerrando o programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != 11);
    }

    static void InserirAluno(Queue<int> fila, string tipoBolsa)
    {
        Console.Write("Digite o código do aluno: ");
        int codigo = int.Parse(Console.ReadLine());
        fila.Enqueue(codigo);
        Console.WriteLine($"Aluno adicionado à fila de {tipoBolsa}.");
    }

    static void RemoverAluno(Queue<int> fila, string tipoBolsa)
    {
        if (fila.Count > 0)
        {
            int codigoRemovido = fila.Dequeue();
            Console.WriteLine($"Aluno removido da fila de {tipoBolsa}. Código: {codigoRemovido}");
        }
        else
        {
            Console.WriteLine($"A fila de {tipoBolsa} está vazia.");
        }
    }

    static void MostrarFila(Queue<int> fila, string tipoBolsa)
    {
        Console.WriteLine($"Fila de {tipoBolsa}:");
        foreach (int codigo in fila)
        {
            Console.WriteLine($"Código: {codigo}");
        }
    }

    static void PesquisarAluno(Queue<int> fila, string tipoBolsa)
    {
        Console.Write("Digite o código do aluno a ser pesquisado: ");
        int codigoPesquisa = int.Parse(Console.ReadLine());
        bool encontrado = fila.Contains(codigoPesquisa);
        Console.WriteLine($"Aluno {(encontrado ? "encontrado" : "não encontrado")} na fila de {tipoBolsa}.");
    }

    static void MostrarPrimeiroAluno(Queue<int> fila, string tipoBolsa)
    {
        if (fila.Count > 0)
        {
            int primeiroAluno = fila.Peek();
            Console.WriteLine($"O aluno no início da fila de {tipoBolsa} tem o código: {primeiroAluno}");
        }
        else
        {
            Console.WriteLine($"A fila de {tipoBolsa} está vazia.");
        }
    }
}
