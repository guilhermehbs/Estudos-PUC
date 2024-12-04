using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(soma(3));

            Console.WriteLine(somaSerie(1,5,2));

            Console.WriteLine(fatorialDuplo(5));

            Console.WriteLine(calculoPell(10));

            Console.WriteLine(mdc(50));

            Console.WriteLine(superFatorial(5));

            Console.WriteLine(fatorial(5));
        }

        static double soma(int n)
        {
            if (n == 0)
                return 0;
            else
                return Math.Pow(n, 3) + soma(n - 1);
        }

        static double somaSerie(int i, int j, int k)
        {
            if (i > j)
            {
                return 0;
            }
            else
            {
                Console.WriteLine($"i = {i} \\ j = {j}");
                return i + somaSerie(i + k, j, k);
            }

        }

        static double fatorialDuplo(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * fatorialDuplo(n - 2);
            }
        }

        static double calculoPell(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return 2 * pell(n - 1) + calculoPell(n - 2);
            }
        }

        static double mdc(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return mdc(y, x % y);
            }
        }

        static double superFatorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return fatorial(n) * superFatorial(n - 1);
            }
        }

        static double fatorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * fatorial(n - 1);
            }
        }
    }
}

