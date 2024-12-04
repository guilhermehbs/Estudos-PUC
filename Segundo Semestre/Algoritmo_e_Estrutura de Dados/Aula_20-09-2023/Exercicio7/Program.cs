using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> filaDeAtendimento = new Queue<string>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Adicionar um cliente à fila");
            Console.WriteLine("2 - Atender um cliente");
            Console.WriteLine("3 - Exibir o número de clientes na fila");
            Console.WriteLine("4 - Exibir o próximo cliente a ser atendido");
            Console.WriteLine("5 - Encerrar o programa");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarCliente();
                    break;
                case 2:
                    AtenderCliente();
                    break;
                case 3:
                    ExibirNumeroDeClientes();
                    break;
                case 4:
                    ExibirProximoCliente();
                    break;
                case 5:
                    Console.WriteLine("Encerrando o programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != 5);
    }

    static void AdicionarCliente()
    {
        Console.Write("Digite o nome do cliente: ");
        string cliente = Console.ReadLine();
        filaDeAtendimento.Enqueue(cliente);
        Console.WriteLine($"Cliente {cliente} adicionado à fila.");
    }

    static void AtenderCliente()
    {
        if (filaDeAtendimento.Count > 0)
        {
            string clienteAtendido = filaDeAtendimento.Dequeue();
            Console.WriteLine($"Cliente {clienteAtendido} atendido e removido da fila.");
        }
        else
        {
            Console.WriteLine("A fila está vazia. Não há clientes para atender.");
        }
    }

    static void ExibirNumeroDeClientes()
    {
        int numeroDeClientes = filaDeAtendimento.Count;
        Console.WriteLine($"Número de clientes na fila: {numeroDeClientes}");
    }

    static void ExibirProximoCliente()
    {
        if (filaDeAtendimento.Count > 0)
        {
            string proximoCliente = filaDeAtendimento.Peek();
            Console.WriteLine($"Próximo cliente a ser atendido: {proximoCliente}");
        }
        else
        {
            Console.WriteLine("A fila está vazia. Não há próximo cliente.");
        }
    }
}
