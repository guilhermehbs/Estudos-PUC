using System;

namespace Exercicio4
{
class Program
    {
        static double calcularMedia (){
            double soma = 0, media;
            double [] vetor = new double []{27.2, 12, 9.5, 15, 9};
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];

            }
            media = soma/3;
            return media;
        }
        static void Main(string[] args)

        {
            double media = 0;
            media = calcularMedia();
            Console.WriteLine("O valor da media: " + media);

        }
    }
}   
