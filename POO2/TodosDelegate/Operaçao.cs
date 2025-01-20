using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosDelegate
{
    internal class Matematica
    {
        public void Soma(int num1, int num2)
        {
            Console.WriteLine("O resultado é:" + (num1 + num2));
        }
        public void Diminuir(int num1, int num2)
        {
            Console.WriteLine("O resultado é:" + (num1 - num2));
        }
        public void Multiplicar(int num1, int num2)
        {
            Console.WriteLine("O resultado é:" + (num1 * num2));
        }
        public void Dividir(int num1, int num2)
        {
            Console.WriteLine("O resultado é:" + (num1 / num2));
        }

        public void Teste(int num1)
        {
            int res = num1 * 100;
            Console.WriteLine("Isso tudo" + res);

        }
    }
}
