using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um valor inteiro positivo n (maior ou igual a 3): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 3)
        {
            Console.WriteLine("O valor de n deve ser maior ou igual a 3.");
            return;
        }

        Stack<int> pilha = new Stack<int>();
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            pilha.Push(a);
            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine($"Os {n} primeiros elementos da sequência de Fibonacci em ordem decrescente:");
        while (pilha.Count > 0)
        {
            Console.Write(pilha.Pop() + " ");
        }
    }
}
