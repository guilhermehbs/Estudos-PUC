/*
using System;

int tamanhovetor = 5;
float[] vetor = new float[tamanhovetor];
float soma = 0;
float media = 0;

Console.WriteLine("Digite um número: ");

for (int i = 0; i < tamanhovetor; i++)
{
    vetor[i] = float.Parse(Console.ReadLine());
    soma += vetor[i];
}


media = soma / tamanhovetor;
Console.WriteLine(media);
*/
using System.Runtime.Serialization;

int[,] matriz = new int[3, 3];
int soma = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Digite um número da "+ i + " linha, e da " + j + " coluna: ");
        matriz[i,j] = int.Parse(Console.ReadLine());
        if (i == j)
        {
            soma += matriz[i, j];
        }
    }
    Console.WriteLine(soma);
}
