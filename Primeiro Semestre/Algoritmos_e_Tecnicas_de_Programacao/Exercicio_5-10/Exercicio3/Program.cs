using System;

namespace Exercicio3
{
class Program
    {
       
        static string verificarNumeroPrimo(int numero)
        {
            int divisor = 1, resto = 0;
            while (divisor<= numero)
            {
                if (numero % divisor == 0)
                {
                    resto += 1;
                }
                divisor += 1;
            }
            if (resto == 2)
            {
                return "O número é primo";
            }
            else
            {
                return "O número não é primo";
            }
        }
                static void Main(string[] args)
    {
            Console.WriteLine("Digite o num inteiro");
            int numero = int.Parse(Console.ReadLine());
            string verificar;
            verificar = verificarNumeroPrimo(numero);
            Console.WriteLine(verificar);
    }
    }
           
}