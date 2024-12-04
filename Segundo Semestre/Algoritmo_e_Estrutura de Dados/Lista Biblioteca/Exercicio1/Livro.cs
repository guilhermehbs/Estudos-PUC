using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Livro
    {
        private string titulo;
        private string autor;
        private int anoPublicacao;
        private int paginas;
        private bool status;
        private string statusDescritivo;

        public Livro(string titulo, string autor, int anoPublicacao, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
            this.paginas = paginas;
            status = true;
            statusDescritivo = "Disponível";
        }

        public void exibirDados(string titulo)
        {
            Console.WriteLine("Titulo: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Ano: " + anoPublicacao);
            Console.WriteLine("Páginas: " + paginas);
            Console.WriteLine("Status: " + statusDescritivo);
        }

        public string getTitulo()
        {
            return titulo;
        }

        public string getStatus()
        {
            return statusDescritivo;
        }

        public void setStatus(string statusDescritivo)
        {
            this.statusDescritivo = statusDescritivo;
            
            if (statusDescritivo == "Disponível")
            {
                this.status = true;
            }
            else
            {
                this.status = false;
            }
        }
        public override string ToString()
        {
            return $"Titulo: {titulo}, Autor: {autor}, Ano de Publicação: {anoPublicacao}, Número de Páginas: {paginas}, Status: {statusDescritivo}";
        }
    }
}
