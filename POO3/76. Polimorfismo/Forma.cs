using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76.Polimorfismo
{
    internal class Forma
    {
        public int Altura = 10;
        public int Largura = 10;

        public virtual void Chamar()
        {
            Console.WriteLine("O Resultado é: ");
        }
        public virtual void Calculo()
        {
                         
        }

    }

    class Mult : Forma
    {
       
        public override void Calculo()
        {
            int res = Altura * Largura;
            Console.WriteLine(res);
        }
    }

    class Somar : Forma
    {
        public override void Chamar()
        {
            Console.WriteLine("O Resultado da Soma: ");
        }
        public override void Calculo()
        {
            int res = Altura + Largura;
            Console.WriteLine(res);
        }
    }

    class Div : Forma
    {
        public override void Chamar()
        {
            Console.WriteLine("O da divisão é: ");
        }
        public override void Calculo()
        {
            int res = Altura / Largura;
            Console.WriteLine(res);
        }
    }
}

