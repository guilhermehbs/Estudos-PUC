using System;

namespace Exercicio2
{
class Program
    {
        static double somaMedia (){
            double soma = 0, media;
            double [] vetor = new double [3];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um número: ");
                vetor[i] = double.Parse(Console.ReadLine());
                soma += vetor[i];

            }
            media = soma/3;
            return media;
        }
        static void Main(string[] args)

        {
            double valor = 0;
            valor = somaMedia();
            Console.WriteLine("O valor da média: " + valor);

        }
    }
}