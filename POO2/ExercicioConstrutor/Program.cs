using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora res = new Calculadora();

            double resultado = res.Soma(2.9, 5.7);
            Console.WriteLine(resultado);

            int resultado2 = res.Soma(5, 4, 3);
            Console.WriteLine(resultado2);

            Console.ReadKey();


        }
    }
}
