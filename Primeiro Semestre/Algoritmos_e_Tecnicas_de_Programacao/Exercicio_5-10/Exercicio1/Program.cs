using System;

namespace Exercicio1
{
class Program
    {
        static void Main(string[] args)
        {
            positivoOuNegativo();
        }
        static int positivoOuNegativo()
        {
            int numero;
            Console.WriteLine("Digite o número:");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo");
            }
            else
            {
                Console.WriteLine("O número é zero");
            }
            return numero;
        }
    }

}