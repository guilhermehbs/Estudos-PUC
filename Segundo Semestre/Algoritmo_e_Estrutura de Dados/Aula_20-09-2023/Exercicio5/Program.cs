using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string: ");
        string inputString = Console.ReadLine();

        string stringInvertida = InverterStringComPilha(inputString);

        Console.WriteLine($"String invertida: {stringInvertida}");
    }

    static string InverterStringComPilha(string input)
    {
        Stack<char> pilha = new Stack<char>();

        foreach (char c in input)
        {
            pilha.Push(c);
        }

        char[] arrayInvertido = new char[input.Length];
        int index = 0;

        while (pilha.Count > 0)
        {
            arrayInvertido[index++] = pilha.Pop();
        }

        return new string(arrayInvertido);
    }
}
