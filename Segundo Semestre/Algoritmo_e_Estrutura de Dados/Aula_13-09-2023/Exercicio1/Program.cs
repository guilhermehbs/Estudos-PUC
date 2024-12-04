using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                int a = 1;

                a *= 1;
                a *= 1;
                a *= 1;
                a *= 1;
                a *= 1;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        int a = 1;

                        a *= 1;
                        a *= 1;
                        a *= 1;
                        a *= 1;
                    }
                }
            }
        }
    }
}