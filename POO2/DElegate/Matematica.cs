using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DElegate
{
    internal class Matematica
    {
        public void Somar(int n1 , int n2)
        {
            Console.WriteLine("O resultado é:" + (n1 + n2));

        }
        public void Diminuir(int n1 , int n2)
        {
            Console.WriteLine("O resultado é:" + (n1 - n2));
        }
        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine("O resultado é:" + (n1 * n2));
        }
        public void Dividir(int n1 , int n2)
        {
            Console.WriteLine("O resultado é:" + (n1 / n2));

        }
    }
}
