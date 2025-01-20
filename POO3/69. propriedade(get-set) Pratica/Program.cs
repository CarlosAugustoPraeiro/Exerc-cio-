using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69.propriedade_get_set__Pratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("Escreva seu nome:_");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:_");
            p.Idade = int.Parse(Console.ReadLine());

            



            p.Apresentar();

            Console.ReadKey();





        }
    }
}
