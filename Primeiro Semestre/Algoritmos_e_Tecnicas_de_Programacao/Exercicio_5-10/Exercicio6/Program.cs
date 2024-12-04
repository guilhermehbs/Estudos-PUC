using System;

namespace Exercicio6
{
 class Program
{
     static void Main(String[] args)
    {
        int[] numeros = { 15, 10, 50, 40, 70 };

        float media = calcularMedia(numeros);
        Console.WriteLine("A média é: " + media);
    }

     static float calcularMedia(int[] numero)
    {
        int soma = 0;

        for (int i = 0; i < numero.Length; i++)
        {
            soma += numero[i];
        }

        float media = (float)soma / numero.Length;
        return media;
    }
}
}