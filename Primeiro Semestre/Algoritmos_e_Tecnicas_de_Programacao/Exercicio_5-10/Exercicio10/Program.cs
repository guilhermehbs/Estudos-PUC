using System;

namespace Exercicio10
{
    class Program
    {
        public static int encontrarMaiorValorSegundaColuna(int[,] matriz)
        {
        int maiorValor = matriz[0, 1];

            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                int valorAtual = matriz[i, 1];

                if (valorAtual > maiorValor)
                {
                    maiorValor = valorAtual;
                }
            }

            return maiorValor;
        }
        static void Main(String[] args)
        {
            int[,] matriz = new int[5, 2]
            {
                { 1, 6 },
                { 2, 7 },
                { 3, 8 },
                { 4, 9 },
                { 5, 10 }
            };

             int maiorValorSegundaColuna = encontrarMaiorValorSegundaColuna(matriz);
            Console.WriteLine("O maior valor na segunda coluna é: " + maiorValorSegundaColuna);
        }
    }
}