using System;

namespace Exercicio7
{
    class Program
    {

        static float valorCentimetro;
        static void metrosParaCentimetro(float metros)
        {
            valorCentimetro = metros * 100;
        }
        static void Main(String[] args)
        {
            Console.Write("Digite o valor em metros: ");
            float valorMetros = float.Parse(Console.ReadLine());

            metrosParaCentimetro(valorMetros);

            Console.WriteLine("O valor em centímetros é: " + valorCentimetro + " cm"); 
        }
    }    
}