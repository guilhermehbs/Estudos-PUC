using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] tamanhos = { 1000, 10000, 100000, 200000 };
        foreach (var tamanho in tamanhos)
        {
            int[] arrayAleatorio = GerarArrayAleatorio(tamanho);
            int[] arrayOrdenado = GerarArrayOrdenado(tamanho);
            int[] arrayInversamenteOrdenado = GerarArrayInversamenteOrdenado(tamanho);

            TestarShellSort("ShellSort", ShellSort, arrayAleatorio, arrayOrdenado, arrayInversamenteOrdenado);
            TestarAlgoritmoOrdenacao("MergeSort", MergeSort, arrayAleatorio, arrayOrdenado, arrayInversamenteOrdenado);
            TestarAlgoritmoOrdenacao("QuickSort", QuickSort, arrayAleatorio, arrayOrdenado, arrayInversamenteOrdenado);
        }

        static void TestarAlgoritmoOrdenacao(string nome, Action<int[], int, int> ordenacao, params int[][] arrays)
        {
            Console.WriteLine($"Testando {nome}");
            foreach (var array in arrays)
            {
                var cronometro = Stopwatch.StartNew();
                ordenacao(array, 0, array.Length - 1);
                cronometro.Stop();
                Console.WriteLine($"Tempo decorrido: {cronometro.ElapsedMilliseconds} ms");
            }
        }

        static void TestarShellSort(string nome, Action<int[]> ordenacao, params int[][] arrays)
        {
            Console.WriteLine($"Testando {nome}");
            foreach (var array in arrays)
            {
                var cronometro = Stopwatch.StartNew();
                ordenacao(array);
                cronometro.Stop();
                Console.WriteLine($"Tempo decorrido: {cronometro.ElapsedMilliseconds} ms");
            }
        }

        static int[] GerarArrayAleatorio(int tamanho)
        {
            Random aleatorio = new Random();
            return Enumerable.Range(0, tamanho).Select(_ => aleatorio.Next()).ToArray();
        }

        static int[] GerarArrayOrdenado(int tamanho)
        {
            return Enumerable.Range(0, tamanho).ToArray();
        }

        static int[] GerarArrayInversamenteOrdenado(int tamanho)
        {
            return Enumerable.Range(0, tamanho).Reverse().ToArray();
        }


        static void ShellSort(int[] array)
        {
            int n = array.Length;
            int intervalo = n / 2;
            int temp;

            while (intervalo > 0)
            {
                for (int i = 0; i + intervalo < n; i++)
                {
                    int j = i + intervalo;
                    temp = array[j];

                    while (j - intervalo >= 0 && temp < array[j - intervalo])
                    {
                        array[j] = array[j - intervalo];
                        j = j - intervalo;
                    }

                    array[j] = temp;
                }

                intervalo = intervalo / 2;
            }
        }

        static void MergeSort(int[] array, int esquerda, int direita)
        {
            if (esquerda < direita)
            {
                int meio = (esquerda + direita) / 2;

                MergeSort(array, esquerda, meio);
                MergeSort(array, meio + 1, direita);

                Merge(array, esquerda, meio, direita);
            }
        }

        static void Merge(int[] array, int esquerda, int meio, int direita)
        {
            int[] arrayEsquerda = new int[meio - esquerda + 1];
            int[] arrayDireita = new int[direita - meio];

            Array.Copy(array, esquerda, arrayEsquerda, 0, meio - esquerda + 1);
            Array.Copy(array, meio + 1, arrayDireita, 0, direita - meio);

            int i = 0;
            int j = 0;
            for (int k = esquerda; k < direita + 1; k++)
            {
                if (i == arrayEsquerda.Length)
                {
                    array[k] = arrayDireita[j];
                    j++;
                }
                else if (j == arrayDireita.Length)
                {
                    array[k] = arrayEsquerda[i];
                    i++;
                }
                else if (arrayEsquerda[i] <= arrayDireita[j])
                {
                    array[k] = arrayEsquerda[i];
                    i++;
                }
                else
                {
                    array[k] = arrayDireita[j];
                    j++;
                }
            }
        }

        static void QuickSort(int[] array, int baixo, int alto)
        {
            if (baixo < alto)
            {
                int pi = Particao(array, baixo, alto);

                QuickSort(array, baixo, pi - 1);
                QuickSort(array, pi + 1, alto);
            }
        }

        static int Particao(int[] array, int baixo, int alto)
        {
            int pivo = array[alto];
            int i = (baixo - 1);

            for (int j = baixo; j <= alto - 1; j++)
            {
                if (array[j] < pivo)
                {
                    i++;
                    Trocar(array, i, j);
                }
            }
            Trocar(array, i + 1, alto);
            return (i + 1);
        }

        static void Trocar(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
