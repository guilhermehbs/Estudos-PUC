using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            printar(6);
        }



        static int multiplicar(int x, int y)
        {
            if(y == 0)
            {
                return 0;
            }
            else
            {
                return x + multiplicar(x, y-1);
            }
        }
        static void printar(int n)
        {
            if (n == 0)
            {
               Console.WriteLine(n);
            }
            else
            {
                printar(n-1);
                Console.WriteLine(n);
            }
        }
    }
}
