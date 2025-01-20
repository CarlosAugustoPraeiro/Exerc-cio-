using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.idade = 5;
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.nome + p1.idade);

            Pessoa p2 = new Pessoa("Carlos", "augusto",  31);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.nome);


            Console.ReadKey();

        }
    }
}
