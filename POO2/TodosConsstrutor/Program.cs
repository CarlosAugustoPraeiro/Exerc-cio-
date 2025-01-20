using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosConsstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.nome = "Guto";

            p1.Apresentar();

            Console.ReadKey();

            Pessoa p2 = new Pessoa("Joca", "Leao", 50);


                p2.Falar();

            


            Console.ReadKey();



        }
    }
}
