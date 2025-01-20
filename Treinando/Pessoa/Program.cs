using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Falar();
            Console.WriteLine("Digite um numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            int num2 = int.Parse(Console.ReadLine());

            p1.Soma(num1, num2);


            Console.ReadKey();
        }
    }
}
