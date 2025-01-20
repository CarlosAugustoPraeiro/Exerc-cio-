using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Todos ex = new Todos();

            ex.nome = "CArlos";
            ex.cidade = " Recife";
            ex.idade = 31;

            ex.Apresentação();

            Console.ReadKey();

        }
    }
}
