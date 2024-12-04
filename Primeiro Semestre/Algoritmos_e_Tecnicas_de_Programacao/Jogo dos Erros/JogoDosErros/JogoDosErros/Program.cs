using System;
using 
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo(a) à Hamburgueria!");

        Hamburguer[] hamburgueres = new Hamburguer[2];
        hamburgueres[0] = new Hamburguer("Cheeseburger", 15.90);
        hamburgueres[1] = new Hamburguer("X-Bacon", 18.50);

        Cliente cliente = new Cliente("João", "Rua das Flores, 123");

        bool sair = false;

        while (!sair)
        {
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Ver cardápio");
            Console.WriteLine("2. Fazer pedido");
            Console.WriteLine("3. Sair");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("--- Cardápio ---");
                    foreach (Hamburguer hamburguer in hamburgueres)
                    {
                        hamburguer.ImprimirDetalhes();
                    }
                    Console.WriteLine("----------------");
                    break;

                case 2:
                    Console.WriteLine("Faça seu pedido:");
                    Console.Write("Nome do hambúrguer: ");
                    string nomeHamburguer = Console.ReadLine();
                    Console.Write("Preço do hambúrguer: ");
                    double precoHamburguer = Convert.ToDouble(Console.ReadLine());

                    Hamburguer novoHamburguer = new Hamburguer(nomeHamburguer, precoHamburguer);
                    Pedido pedido = new Pedido(cliente, novoHamburguer);
                    pedido.ImprimirDetalhes();
                    break;

                case 3:
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        Console.WriteLine("Obrigado por utilizar a Hamburgueria. Volte sempre!");
    }
}