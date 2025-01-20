using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DElegate
{
    internal class Program
    {
        delegate void Operacao (int num1 , int num2);
        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Operacao conta = null;
           // importanta saber a logica, ainda um pouco confuso 
            conta += m.Diminuir;
            conta += m.Somar;
            conta(8, 6);

            conta -= m.Somar;
            conta += m.Multiplicar;
            conta(5,5);


            Console.ReadKey();


        }
    }
}
