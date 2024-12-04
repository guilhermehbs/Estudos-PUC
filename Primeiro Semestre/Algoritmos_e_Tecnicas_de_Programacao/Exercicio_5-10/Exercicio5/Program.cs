using System;

namespace Exercicio5
{
 class Program
{
     static void Main(String[] args)
    {
        string[] nomes = { "Lucas", "Gabriel", "Renata", "Leandro" };

        imprimirNomes(nomes);
    }

     static void imprimirNomes(string[] nomes)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine(nomes[i]);
        }
    }
}
}