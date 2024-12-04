using System;
using System.Collections.Generic;

class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Contato> agenda = new List<Contato>();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar novo contato");
            Console.WriteLine("2 - Atualizar informações de um contato");
            Console.WriteLine("3 - Excluir um contato");
            Console.WriteLine("4 - Listar todos os contatos");
            Console.WriteLine("5 - Sair");

            int escolha;
            if (int.TryParse(Console.ReadLine(), out escolha))
            {
                switch (escolha)
                {
                    case 1:
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("E-mail: ");
                        string email = Console.ReadLine();
                        Contato novoContato = new Contato { Nome = nome, Telefone = telefone, Email = email };
                        agenda.Add(novoContato);
                        Console.WriteLine("Contato adicionado com sucesso.");
                        break;
                    case 2:
                        Console.Write("Digite o nome do contato a ser atualizado: ");
                        string nomeAtualizar = Console.ReadLine();
                        Contato contatoAtualizar = agenda.Find(contato => contato.Nome == nomeAtualizar);
                        if (contatoAtualizar != null)
                        {
                            Console.Write("Novo telefone: ");
                            string novoTelefone = Console.ReadLine();
                            Console.Write("Novo e-mail: ");
                            string novoEmail = Console.ReadLine();
                            contatoAtualizar.Telefone = novoTelefone;
                            contatoAtualizar.Email = novoEmail;
                            Console.WriteLine("Contato atualizado com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;
                    case 3:
                        Console.Write("Digite o nome do contato a ser excluído: ");
                        string nomeExcluir = Console.ReadLine();
                        Contato contatoExcluir = agenda.Find(contato => contato.Nome == nomeExcluir);
                        if (contatoExcluir != null)
                        {
                            agenda.Remove(contatoExcluir);
                            Console.WriteLine("Contato excluído com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Lista de contatos:");
                        foreach (var contato in agenda)
                        {
                            Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}, E-mail: {contato.Email}");
                        }
                        break;
                    case 5:
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
