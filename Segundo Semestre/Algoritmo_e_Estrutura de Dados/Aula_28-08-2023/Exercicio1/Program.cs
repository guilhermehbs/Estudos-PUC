using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calculaSomatoriaDosNumeros(0));
        }

        static int calculaSomatoriaDosNumeros(int n)
        {
            if(n == 1) 
            {
                return 1;
            }
            else
            {
                return n + calculaSomatoriaDosNumeros(n - 1);
            }
        }
    }
}
