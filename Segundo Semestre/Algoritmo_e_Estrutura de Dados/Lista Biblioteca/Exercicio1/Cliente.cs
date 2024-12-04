using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;


namespace Exercicio1
{
    class Cliente
    {
        private string nome;
        private int id;
        public List<Livro> listaLivrosEmprestados;
 

        public Cliente(string nome)
        {
            this.nome = nome;

            Random random = new Random();
            id = random.Next(1001);
            Console.WriteLine("Id: " + id);
            listaLivrosEmprestados = new List<Livro>();
        }

        public void emprestarLivro(Livro livro)
        {
            if (livro.getStatus() == "Disponível")
            {
                livro.setStatus("Emprestado");
                listaLivrosEmprestados.Add(livro);
            }
            else
            {
                Console.WriteLine("Livro não está disponível para empréstimo.");
            }
        }

        public void devolverLivro(Livro livro)
        {
            if (listaLivrosEmprestados.Contains(livro))
            {
                livro.setStatus("Disponível");
                listaLivrosEmprestados.Remove(livro);
            }
            else
            {
                Console.WriteLine("Livro não está na lista de livros emprestados por este cliente.");
            }
        }

        public void exibirDados(int id)
        {
            Console.WriteLine("Nome do cliente: " + nome);
            Console.WriteLine("Id do cliente: " + id);
            Console.WriteLine("Lista de livros emprestados: ");

            foreach(var livro in listaLivrosEmprestados)
            {
                Console.WriteLine($"{livro}");
            }

        }

        public void exibirListaDeLivrosEmprestados(string nome)
        {
            foreach (var livro in listaLivrosEmprestados)
            {
                Console.WriteLine($"{livro}");
            }
        }

        public int getId()
        {
            return id;
        }

        public string getNome()
        {
            return nome;
        }

        public override string ToString()
        {
            return $"Nome: {nome}, Id: {id}";
        }
    }
}


//public void emprestaLivro(int id, string titulo, Livro livro)
//{
//    for (int i = 0; i < 2; i++)
//    {
//        if (livro.getStatus() == true)
//        {

//            if (listaLivrosEmprestados[i] != null)
//            {
//                listaLivrosEmprestados.Add(titulo);
//                livro.alteraStatus(titulo);
//            }
//            else
//            {
//                Console.WriteLine("Você já tem 2 livros emprestados");
//            }
//        }
//        else
//        {
//            Console.WriteLine("O livro já está emprestado");
//        }
//    }
//}

//public void devolverLivro(int id, string titulo, Livro livro)
//{
//    if (listaLivrosEmprestados.Contains(titulo))
//    {
//        for (int i = 0; i < 2; i++)
//        {
//            if (listaLivrosEmprestados[i] == titulo)
//            {
//                listaLivrosEmprestados.Remove(titulo);
//                livro.alteraStatus(titulo);
//            }
//            else
//            {
//                Console.WriteLine("O livro não está na lista de livros");
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("O livro não está na lista de livros do cliente");
//    }
//}
