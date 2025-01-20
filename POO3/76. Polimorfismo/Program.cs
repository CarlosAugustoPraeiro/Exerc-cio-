using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _76.Polimorfismo
{
    internal class Program
    {
        // aqui a forma de de criar a herança mudou. Isso é o polimorfismo.
        static void Main(string[] args)
        {
            Forma m = new Mult();
            Forma s = new Somar();
            Forma d = new Div();


            m.Altura = 15;
            m.Largura = 10;

            m.Chamar();
            m.Calculo();

            s.Calculo();

            Console.ReadKey();
        }
    }
}
