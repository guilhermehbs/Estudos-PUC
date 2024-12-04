using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Retangulo
    {
        int largura;
        int altura;

        public Retangulo(int largura, int altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public int calculaPerimetro(int largura, int altura)
        {
            return (largura * 2) + (altura * 2); 
        }

        public int calculaArea(int largura, int altura) 
        {
            return largura * altura;
        }
    }
}
