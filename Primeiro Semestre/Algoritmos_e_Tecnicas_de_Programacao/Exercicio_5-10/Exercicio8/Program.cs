using System;

namespace Exercicio8
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a base do triângulo: ");
        double @base = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do triângulo: ");
        double altura = double.Parse(Console.ReadLine());

        double[] vetor = areaTriangulo(@base, altura);

        Console.WriteLine("A área do triângulo é: " + vetor[0]);
    }

    static double[] areaTriangulo(double @base, double altura)
    {
        double area = (@base * altura) / 2;

        double[] resultado = new double[3];
        resultado[0] = area;
        resultado[1] = @base;
        resultado[2] = altura;

        return resultado;
    }
}
}
