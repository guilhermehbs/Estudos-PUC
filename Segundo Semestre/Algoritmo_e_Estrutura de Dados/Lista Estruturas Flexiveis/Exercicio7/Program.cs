using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args) 
        {

            Agenda listaDeContatos = new Agenda();

            listaDeContatos.AdicionarContato("Guilherme", "984107426", "gui100920@gmail.com");

            listaDeContatos.ListarContatos();

        }      
    }
}
