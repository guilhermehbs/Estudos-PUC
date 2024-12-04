using System;

namespace Exercicio9
{
    class Program
    {
            public static int calcularSomaMatriz(int[,] matriz)
            {
                int soma = 0;

                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {

                        soma += matriz[i, j];

                    }
                }

                return soma;
            }
        static void Main(String[] args)
        {
            int[,] matriz = new int[3, 3];
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;
            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;
            matriz[2, 0] = 7;
            matriz[2, 1] = 8;
            matriz[2, 2] = 9;

            int soma = calcularSomaMatriz(matriz);

            Console.WriteLine("A soma dos elementos da matriz é igual a: " + soma);
        }
    }
}