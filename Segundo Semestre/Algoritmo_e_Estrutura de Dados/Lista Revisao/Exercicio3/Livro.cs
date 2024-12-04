using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Livro
    {
        private string titulo;
        private string autor;
        private int anoPublicacao;
        private string genero;

        public Livro(string titulo, string autor, int anoPublicacao, string genero)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
            this.genero = genero;
        }

        public string exibirInformacoes()
        {
            return $"Título: {titulo} \n" +
                    $"Autor: {autor} \n" +
                    $"Ano de Publicação: {anoPublicacao} \n" +
                    $"Gênero: {genero} \n";
        }

        public bool ehFiccao()
        {
            return genero.ToLower() == "ficção";
        }
    }
}
